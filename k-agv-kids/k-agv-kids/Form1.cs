using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.IO;
using System.Security.Cryptography;

using System.Runtime.InteropServices;
namespace k_agv_kids
{

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            
            init();
            //just to be initialized.
            myagv = new agv(1);
            initType(1);

        }

        private void pb_left_MouseDown(object sender, MouseEventArgs e)
        {
           
                
                Clipboard.Clear();//Empty the clipboard
                Application.DoEvents();

                //Tricky way to detect which button pressed
                if ((sender as PictureBox).Name == "pb_left")
                {
                    pb_backcolor = pb_left.BackColor;
                    pb_left.BackColor = Color.Gray;


                    _tempImage = new Bitmap(pb_left.Image, new Size(25, 25));//create new image based on PB's one
                    Clipboard.SetImage(_tempImage); //Set it to Clipboard
                    tb_commands.Paste(); //Paste it to RichBox
                    commands += "<";//add the command to our 'command vault'
                    commandCounter++;
                    commandPressed(true);

                }
                else if ((sender as PictureBox).Name == "pb_right")
                {
                    pb_backcolor = pb_left.BackColor;
                    pb_right.BackColor = Color.Gray;


                    _tempImage = new Bitmap(pb_right.Image, new Size(25, 25));//create new image based on PB's one
                    Clipboard.SetImage(_tempImage); //Set it to Clipboard
                    tb_commands.Paste(); //Paste it to RichBox
                    commands += ">";//add the command to our 'command vault'
                    commandCounter++;
                    commandPressed(true);

                }
                else if ((sender as PictureBox).Name == "pb_up")
                {
                    pb_backcolor = pb_left.BackColor;
                    pb_up.BackColor = Color.Gray;


                    _tempImage = new Bitmap(pb_up.Image, new Size(25, 25));//create new image based on PB's one
                    Clipboard.SetImage(_tempImage); //Set it to Clipboard
                    tb_commands.Paste(); //Paste it to RichBox
                    commands += "^";//add the command to our 'command vault'
                    commandCounter++;
                    commandPressed(true);

                }
                else if ((sender as PictureBox).Name == "pb_down")
                {
                    pb_backcolor = pb_left.BackColor;
                    pb_down.BackColor = Color.Gray;


                    _tempImage = new Bitmap(pb_down.Image, new Size(25, 25));//create new image based on PB's one
                    Clipboard.SetImage(_tempImage); //Set it to Clipboard
                    tb_commands.Paste(); //Paste it to RichBox
                    commands += "V";//add the command to our 'command vault'
                    commandCounter++;
                    commandPressed(true);

                }
                else if ((sender as PictureBox).Name == "pb_lift")
                {
                    pb_backcolor = pb_left.BackColor;
                    pb_lift.BackColor = Color.Gray;


                    _tempImage = new Bitmap(pb_lift.Image, new Size(25, 25));//create new image based on PB's one
                    Clipboard.SetImage(_tempImage); //Set it to Clipboard
                    tb_commands.Paste(); //Paste it to RichBox
                    commands += "L";//add the command to our 'command vault'
                    commandCounter++;
                    commandPressed(true);

                }
                else if ((sender as PictureBox).Name == "pb_start") //pb_start.THIS IS WHY THERE IS NO EVENT ON PLAY BUTTON.
                {
                    if (isFirstRun)
                    {
                        isRunning = true;
                    }
                
                    if (!commandPressed())
                    {
                        //if no command pressed ,get the PLAY button out of order
                        orderme_timer.Start();

                        return;
                    }

                    if (batteryToolStripMenuItem.Enabled)
                    {
                        batteryToolStripMenuItem.Enabled = false;
                        petrolToolStripMenuItem.Enabled = false;
                        lPGToolStripMenuItem.Enabled = false;
                    }

                   
                    if (isRunning)
                    {

                        pb_start.Image = Image.FromFile(getResDir() + "start.png");
                        commands_array = new char[500];
                        commands_array = commands.ToCharArray();
                        if (isFirstRun)
                        {
                            isFirstRun = !isFirstRun;
                        }
                        anim_timer.Start();
                    }
                    else
                    {
                        groupBox1.Enabled = true;
                        anim_timer.Stop();
                    }
                    isRunning = !isRunning;

            }
            
        }
        private void pb_left_MouseUp(object sender, MouseEventArgs e)
        {
            pb_left.BackColor
                            = pb_right.BackColor
                            = pb_up.BackColor
                            = pb_down.BackColor
                            = pb_lift.BackColor
                            = pb_backcolor;

        }

        private void commandsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tb_commands.Clear();
        }

        private void scoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            score_label.Text = "0";
        }

        private void allToolStripMenuItem_Click(object sender, EventArgs e)
        {
            game_panel.Invalidate();
            removeControls(game_panel, typeof(PictureBox));
            reset(false);
        }



        private void levelEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Run the editor.RELEASE ONLY
            //Process.Start(Directory.GetCurrentDirectory() + "\\editor.exe");
            MessageBox.Show("This feature is working only on release version.\r\nPlease build from scratch.");
        }


        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            
            
            
            ofd_level.Filter = "k-aGv Map (*.kmap)|*.kmap";
            ofd_level.FileName = "";

            if (ofd_level.ShowDialog() == DialogResult.OK)
            {
                removeControls(game_panel, typeof(PictureBox));
                reset(false);

                loads_c = 0;
                obstacles_c = 0;

                groupBox1.Enabled = true;
                StreamReader reader = new StreamReader(ofd_level.FileName);

                reader.ReadLine();//read the first line "Map Info:"
                string map_details = reader.ReadLine(); //second line are the map's details

                //Start second line's split
                char[] delim = { ' ' };
                string[] words = map_details.Split(delim);

                bool isNumber;
                int _tempNumber;
                int whichNumber = 1;
                foreach (string _s in words)
                {
                    isNumber = int.TryParse(_s, out _tempNumber);
                    if (isNumber)
                    {
                        if (whichNumber == 1)
                        {
                            width_blocks = Convert.ToInt32(_s);
                            whichNumber++;
                        }
                        else if (whichNumber == 2)
                        {
                            height_blocks = Convert.ToInt32(_s);
                            whichNumber++;
                        }
                        else
                        {
                            res_offset = Convert.ToInt32(_s);
                            //res_offset is the NumericUpDown value from EDITOR.=25
                        }

                    }
                }
                //End of data import

                //skip the 3rd line
                reader.ReadLine();

                //create the map array
                map = new int[width_blocks, height_blocks];

                //parse the map
                //prepare the delims to get coords
                words = reader.ReadLine().Split(delim);

                for (int z = 0; z < map.GetLength(1); z++)
                {

                    int i = 0;
                    foreach (string _s in words)
                    {
                        map[i, z] = Convert.ToInt32(_s);
                        if (Convert.ToInt32(_s) == 1)
                        {
                            entrance_x = i;
                            entrance_y = z;
                        }
                        i++;

                    }
                    if (z == map.GetLength(1) - 1)
                    { } //no break = error when trying to read the map.getlenght(1) line
                    else
                        words = reader.ReadLine().Split(delim);
                }
                reader.Close();
                ShowMap(map);
                drawGrid(res_offset);
                pb_start.Visible = true;

            }

        }

        private void anim_timer_Tick(object sender, EventArgs e)
        {

            groupBox1.Enabled = false;
            pb_start.Visible = false;
            if (animCounter == commandCounter)
            {
               
                pb_start.Visible = true;
                commandPressed(false);
                isRunning = !isRunning;
                cleanVars();
                groupBox1.Enabled = true;
                anim_timer.Stop();
                return;
            }
            else
            {

                score_label.Text = Convert.ToString(Convert.ToInt32(score_label.Text) + 10);
                if (commands_array[animCounter] == '<') //move 1 box left
                {
                    int i = 0;
                    while (i < obstacles_c) //tries to find which block is 
                    {
                        if (checkForObstacle(agv, i, '<'))
                        {
                            obstacle_found = true;
                            break;
                        }
                        i++;
                    }

                    if (!obstacle_found)
                    {
                        if (isWallOnNextMove('<'))
                        {
                            warning = true;
                            updateWarningState();
                        }
                        else
                        {

                            tempLocation = new Point(agv.Location.X - res_offset, agv.Location.Y);
                            agv.Location = tempLocation;
                            drawGrid(res_offset);
                            emissions(agvtype);
                            animCounter++;

                        }
                    }
                    else
                    {
                        warning = false;
                        updateWarningState();
                        reset(true);
                        warning = true;
                        updateWarningState();
                        groupBox1.Enabled = true;
                        anim_timer.Stop();
                    }
                }
                else if (commands_array[animCounter] == '>') //move 1 box right
                {
                    int i = 0;
                    while (i < obstacles_c)
                    {
                        if (checkForObstacle(agv, i, '>'))
                        {
                            obstacle_found = true;
                            break;
                        }
                        i++;
                    }
                    if (!obstacle_found)
                    {
                        if (isWallOnNextMove('>'))
                        {
                            warning = true;
                            updateWarningState();
                            groupBox1.Enabled = true;
                            anim_timer.Stop();

                        }
                        else
                        {
                            warning = false;
                            updateWarningState();
                            tempLocation = new Point(agv.Location.X + res_offset, agv.Location.Y);
                            agv.Location = tempLocation;
                            drawGrid(res_offset);
                            emissions(agvtype);
                            animCounter++;
                        }
                    }
                    else
                    {
                        reset(true);
                        warning = true;
                        updateWarningState();
                        groupBox1.Enabled = true;
                        anim_timer.Stop();
                    }


                }
                else if (commands_array[animCounter] == 'V') //move 1 box down
                {

                    int i = 0;
                    while (i < obstacles_c)
                    {
                        if (checkForObstacle(agv, i, 'V'))
                        {
                            obstacle_found = true;
                            break;
                        }
                        i++;
                    }
                    if (!obstacle_found)
                    {
                        if (isWallOnNextMove('V'))
                        {
                            warning = true;
                            updateWarningState();
                            groupBox1.Enabled = true;
                            anim_timer.Stop();
                        }
                        else
                        {
                            warning = false;
                            updateWarningState();
                            tempLocation = new Point(agv.Location.X, agv.Location.Y + res_offset);
                            agv.Location = tempLocation;
                            drawGrid(res_offset);
                            emissions(agvtype);
                            animCounter++;
                        }
                    }
                    else
                    {
                        reset(true);
                        warning = true;
                        updateWarningState();
                        groupBox1.Enabled = true;
                        anim_timer.Stop();
                    }

                }
                else if (commands_array[animCounter] == '^') //move 1 box up
                {

                    int i = 0;
                    while (i < obstacles_c)
                    {
                        if (checkForObstacle(agv, i, '^'))
                        {
                            obstacle_found = true;
                            break;
                        }
                        i++;
                    }
                    if (!obstacle_found)
                    {
                        if (isWallOnNextMove('^'))
                        {
                            warning = true;
                            updateWarningState();
                            groupBox1.Enabled = true;
                            anim_timer.Stop();
                        }
                        else
                        {
                            warning = false;
                            updateWarningState();
                            tempLocation = new Point(agv.Location.X, agv.Location.Y - res_offset);
                            agv.Location = tempLocation;
                            drawGrid(res_offset);
                            emissions(agvtype);
                            animCounter++;
                        }
                    }
                    else
                    {
                        reset(true);
                        warning = true;
                        updateWarningState();
                        groupBox1.Enabled = true;
                        anim_timer.Stop();
                    }


                }
                else //lift
                {
                    for (int i = 0; i < loads_c; i++)
                    {
                        if (checkForLoad(agv, i))
                        {
                            if (!isLoaded)
                            {
                                agv.Image = Image.FromFile(getResDir() + "half.png");
                                load_timer.Start();
                                loadsreduceby1(loadCounter);

                                groupBox1.Enabled = true;
                                anim_timer.Stop(); //re-enabled because load would cause agv to stuck
                            }
                        }
                        else if (checkForExit(agv))
                        {
                            agv.Image = Image.FromFile(getResDir() + "empty.png");
                            isLoaded = false;
                        }

                    }
                    loadCounter = 0;
                    animCounter++;
                }

              

                if (pb_battery.Value < pb_battery.Maximum - 60)
                {
                    if (!pb_color_change)
                        if (pbColorChanger.SetState(pb_battery, 1) == 1)
                        {
                            pb_color_change = true;
                            pbColorChanger.SetState(pb_battery, 2);
                        }
                    if (pb_color_change && !pb_color_change_next_step)
                    {
                        pb_color_change_next_step = true;
                        pb_battery.Value -= 2;
                    }
                    if (pb_battery.Value - 2 != 0)
                    {
                        if (pb_color_change && pb_color_change_next_step)
                        {
                            pb_battery.Value -= 2;
                        }
                    }
                    else
                    {
                        pb_battery.Value = pb_battery.Minimum;
                        anim_timer.Stop();
                        MessageBox.Show("You have ran out of fuel.\r\nGame is Over");
                        if (anim_timer.Enabled)
                        {
                           groupBox1.Enabled = true;
                            anim_timer.Stop();
                        }
                        pb_start.Visible = false;
                    }


                    low_fuel.Text = "Low fuel!";
                    low_fuel.ForeColor = Color.Red;
                    low_fuel.Visible = true;
                    using (SolidBrush b = new SolidBrush(Color.Red))
                    {
                        for_warning.FillEllipse(b, 5, 5, 20, 20);
                        warning = true;
                    }

                }
                else
                {
                    if (pbColorChanger.SetState(pb_battery, 2) == 2)
                    {
                        pbColorChanger.SetState(pb_battery, 1);
                    }
                    pb_battery.Value -= 2;

                }
                if (checkForFuelStation(agv) && wantGetRefuelled())
                {
                    getRefuelled();
                }
            }
            
        }

        private void refuel_timer_Tick(object sender, EventArgs e)
        {
            debug2.Text = "Refuelling " + (3 - seconds);
            System.Threading.Thread.Sleep(1000);//We need sleep here because we want to stop animation while it is refuelling

            seconds++;
            if (seconds == 3)
            {
                anim_timer.Start();
                groupBox1.Enabled = true;
                refuel_timer.Stop();
            }

        }

        private void load_timer_Tick(object sender, EventArgs e)
        {
                agv.Image = Image.FromFile(getResDir() + "full.png");
                isLoaded = true;
                groupBox1.Enabled = true;
                load_timer.Stop();
                anim_timer.Start();
        }

        private void batteryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            initType(1);
        }

        private void petrolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            initType(2);
        }

        private void lPGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            initType(3);
        }

        private void orderme_timer_Tick(object sender, EventArgs e)
        {
            lb_orderme.Visible = !lb_orderme.Visible;
            orderme_time += orderme_timer.Interval;
            if (orderme_time == 1500)
            {
                lb_orderme.Visible = false;
                orderme_time = 0;
               groupBox1.Enabled = true;
                orderme_timer.Stop();
            }
           
        }


        private void Form1_Move(object sender, EventArgs e)
        {
            int offsetX = this.Location.X + game_panel.Location.X + game_panel.Width + 30;
            int offsetY =  this.Location.Y + game_panel.Location.Y + game_panel.Height + 30;
            if (offsetX > Screen.PrimaryScreen.Bounds.Width-offsetX
                ||offsetY > Screen.PrimaryScreen.Bounds.Height-(game_panel.Width+game_panel.Location.X)
                 )
            {
                if (drawnGridOnce)
                {
                    game_panel.Refresh();
                    drawGrid(res_offset);
                    cleanedOnce = true;
                }

            }
            else
            {
                if (cleanedOnce)
                {
                    drawGrid(res_offset);
                }
            }
            
          
        }

       

      

    }
}
