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
            kidagv = new agv(1);
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
            }
            else //pb_start.THIS IS WHY THERE IS NO EVENT ON PLAY BUTTON.
            {
                isRunning = !isRunning;
                if (isRunning)
                {
                    pb_start.Image = Image.FromFile(getResDir() + "start.png");
                    commands_array = new char[commandCounter];
                    commands_array = commands.ToCharArray();
                    if (isFirstRun)
                    {
                        isFirstRun = !isFirstRun;
                    }
                    anim_timer.Start();
                }
                else
                {
                    commands = "";
                    isRunning = !isRunning;
                    anim_timer.Stop();
                }

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



        private void levelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            level_label.Text = "1";
        }

        private void aGVStageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Will work on it
        }

        private void allToolStripMenuItem_Click(object sender, EventArgs e)
        {
            game_panel.Invalidate();
            removeControls(game_panel, typeof(PictureBox));
            reset(false);
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reset(false);
            drawGrid(grid_res);
            //StartFromLevel_1();
        }

        private void levelEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Run the editor.RELEASE ONLY
            //Process.Start(Directory.GetCurrentDirectory() + "\\editor.exe");
            MessageBox.Show("This feature is working only on release version.\r\nPlease build from scratch.");
        }


        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {

            reset(false);
            removeControls(game_panel, typeof(PictureBox));
            
            ofd_level.Filter = "k-aGv Map (*.kmap)|*.kmap";
            ofd_level.FileName = "";
            level_label.Text = "Custom level";

            if (ofd_level.ShowDialog() == DialogResult.OK)
            {

                groupBox1.Visible = true;
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
            pb_start.Visible = false;
            if (animCounter == commandCounter)
            {
                isRunning = !isRunning;
                pb_start.Visible = true;
                useArrows(true);
                anim_timer.Stop();
            }
            else
            {
                useArrows(false);

                if (pb_battery.Value < pb_battery.Maximum - 6)
                {
                    pbColorChanger.SetState(pb_battery, 2);
                    emission_status.Text = "Low fuel!";
                    emission_status.ForeColor = Color.Red;
                    using (SolidBrush b = new SolidBrush(Color.Red))
                    {
                        for_warning.FillEllipse(b, 5, 5, 20, 20);
                        warning = true;
                    }
                }


                score_label.Text = Convert.ToString(Convert.ToInt32(score_label.Text) + 10);
                if (commands_array[animCounter] == '<') //move 1 box left
                {

                    if (isWallOnNextMove('<'))
                    {
                        
                        reset(true);
                       // MessageBox.Show("Wall ahead!Give me commands again!");
                        warning = true;
                        updateWarningState();


                    }
                    else
                    {
                        tempLocation = new Point(agv.Location.X - res_offset, agv.Location.Y);
                        agv.Location = tempLocation;
                        drawGrid(res_offset);
                        pb_battery.Value -= 1;
                    }

                }
                else if (commands_array[animCounter] == '>') //move 1 box right
                {
                    if (isWallOnNextMove('>'))
                    {
                      
                        reset(true);
                       // MessageBox.Show("Wall ahead!Give me commands again!");
                        warning = true;
                        updateWarningState();
                        anim_timer.Stop();

                    }
                    else
                    {
                        tempLocation = new Point(agv.Location.X + res_offset, agv.Location.Y);
                        agv.Location = tempLocation;
                        drawGrid(res_offset);
                        pb_battery.Value -= 1;
                    }


                }
                else if (commands_array[animCounter] == 'V') //move 1 box down
                {
                    if (isWallOnNextMove('V'))
                    {
                        
                        reset(true);
                        //MessageBox.Show("Wall ahead!Give me commands again!");
                        warning = true;
                        updateWarningState();
                        anim_timer.Stop();
                    }
                    else
                    {
                        tempLocation = new Point(agv.Location.X, agv.Location.Y + res_offset);
                        agv.Location = tempLocation;
                        drawGrid(res_offset);
                        pb_battery.Value -= 1;
                    }

                }
                else if (commands_array[animCounter] == '^') //move 1 box up
                {
                    if (isWallOnNextMove('^'))
                    {
                        
                        reset(true);
                        //MessageBox.Show("Wall ahead!Give me commands again!");
                        warning = true;
                        updateWarningState();
                        anim_timer.Stop();
                    }
                    else
                    {
                        tempLocation = new Point(agv.Location.X, agv.Location.Y - res_offset);
                        agv.Location = tempLocation;
                        drawGrid(res_offset);
                        pb_battery.Value -= 1;
                    }

                }
                else //lift
                {
                    agv.Image = Image.FromFile(getResDir() + "half.png");
                    load_timer.Start();
                    anim_timer.Stop();
                }

                if (checkForFuelStation(agv) && wantGetRefuelled())
                {
                    getRefuelled();
                }


                animCounter++;


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
                refuel_timer.Stop();
            }

        }

        private void load_timer_Tick(object sender, EventArgs e)
        {
            if (isLoaded == false)
            {
                agv.Image = Image.FromFile(getResDir() + "full.png");
                isLoaded = true;
                load_timer.Stop();
                anim_timer.Start();
            }
            else
            {
                agv.Image = Image.FromFile(getResDir() + "empty.png");
                isLoaded = false;
                load_timer.Stop();
                anim_timer.Start();
            }
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




    }
}
