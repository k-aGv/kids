using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.IO;

namespace k_agv_kids
{
    public partial class Form1 : Form
    {
        public int _colorstate;

        bool isRunning = false;
        bool warning = false;
        bool isFirstRun = true;

        Graphics for_warning;
        Graphics for_grid;

        Color pb_backcolor;
        Bitmap _tempImage;

        PictureBox agv = new PictureBox();
        PictureBox[] pb_array = new PictureBox[100];

        int[] loads = new int[100];
        int loads_c=0; 
        int k = 0; //test value-counter for loadreduceby1
        int[] obstaclescounter = new int[100];
        int obstacles_c=0;
        bool obstacle_found = false;

        //pb_battery bools
        bool pb_color_change = false;
        bool pb_color_change_next_step = false;

        agv kidagv;
        int agvtype;

        int array_counter = 0;
        bool isLoaded = false;
        char[] commands_array;

        int grid_res = 50;//levels should have a random resolution 

        int[,] map;
        int entrance_x, entrance_y;
        int exitCounter;

        int stationCounter;
        int[] loadscounter = new int[100]; //this is something to count how many loads I have in my map

        int width_blocks, height_blocks, res_offset;
        string commands = "";
        int commandCounter = 0;
        Point tempLocation = new Point(0, 0);
        int animCounter = 0;

        int seconds = 0;

        int orderme_time = 0;

        //emissions
        double co2 = 0;
        double co = 0;
        double nox = 0;
        double thc = 0;
        double global = 0;
       
        public void initType(int _type)
        {
            if (_type == 1)
            {
                agvtype = 1;
                type.Text = "Battery";
                type_label.Text = "Battery level:";
                kidagv = new agv(1);
                pb_battery.Value = 100;
                batteryToolStripMenuItem.Checked = true;
                petrolToolStripMenuItem.Checked = false;
                lPGToolStripMenuItem.Checked = false;
            }
            else if (_type == 2)
            {
                agvtype = 2;
                type.Text = "Petrol";
                type_label.Text = "Petrol level:";
                kidagv = new agv(2);
                //emissions has to start from value '0'
                batteryToolStripMenuItem.Checked = false;
                petrolToolStripMenuItem.Checked = true;
                lPGToolStripMenuItem.Checked = false;
            }
            else
            {
                agvtype = 3;
                type.Text = "LPG";
                type_label.Text = "LPG level:";
                kidagv = new agv(3);
                //emissions has to start from value '0'
                batteryToolStripMenuItem.Checked = false;
                petrolToolStripMenuItem.Checked = false;
                lPGToolStripMenuItem.Checked = true;
            }
        }

        public void emissions(int _type)
        {
            if (_type == 1)//electric
            {
                if (isLoaded)
                {
                    co2_emissions_value.Text = 0+"";
                    co2_emissions_text.Text = " gr / km";

                    co_emissions_value.Text = 0+"";
                    co_emissions_text.Text = " gr / km";

                    nox_emissions_value.Text = 0+"";
                    nox_emissions_text.Text = " gr / km";

                    thc_emissions_value.Text = 0+"";
                    thc_emissions_text.Text = " gr / km";

                    global += 0.67/100;
                    global_warming_emissions_value.Text = global + "";
                    global_warming_emissions_text.Text = " kgr / km";
                }
                else
                {
                    co2_emissions_value.Text = 0 + "";
                    co2_emissions_text.Text = " gr / km";

                    co_emissions_value.Text = 0 + "";
                    co_emissions_text.Text = " gr / km";

                    nox_emissions_value.Text = 0 + "";
                    nox_emissions_text.Text = " gr / km";

                    thc_emissions_value.Text = 0 + "";
                    thc_emissions_text.Text = " gr / km";

                    global += 0.64/100;
                    global_warming_emissions_value.Text = global + "";
                    global_warming_emissions_text.Text = " kgr / km";
                }
            }
            else if (_type == 2)//petrol
            {
                if (isLoaded)
                {
                    co2 += 2130.11 / 100;
                    co2_emissions_value.Text = co2 + "";
                    co2_emissions_text.Text = " gr / km";

                    co += 7.28 / 100;
                    co_emissions_value.Text = co + "";
                    co_emissions_text.Text = " gr / km";

                    nox += 20.16 / 100;
                    nox_emissions_value.Text = nox + "";
                    nox_emissions_text.Text = " gr / km";

                    thc += 1.77 / 100;
                    thc_emissions_value.Text = thc + "";
                    thc_emissions_text.Text = " gr / km";

                    global += 2.49 / 100;
                    global_warming_emissions_value.Text = global + "";
                    global_warming_emissions_text.Text = " kgr / km";

                }
                else
                {
                    co2 += 1510.83 / 100;
                    co2_emissions_value.Text = co2 + "";
                    co2_emissions_text.Text = " gr / km";

                    co += 3.84 / 100;
                    co_emissions_value.Text = co + "";
                    co_emissions_text.Text = " gr / km";

                    nox += 14.33 / 100;
                    nox_emissions_value.Text = nox + "";
                    nox_emissions_text.Text = " gr / km";

                    thc += 1.08 / 100;
                    thc_emissions_value.Text = thc + "";
                    thc_emissions_text.Text = " gr / km";

                    global += 1.2 / 100;
                    global_warming_emissions_value.Text = global + "";
                    global_warming_emissions_text.Text = " kgr / km";
                }

            }
            else //LPG
            {
                if (isLoaded)
                {
                    co2 += 2959.57 / 100;
                    co2_emissions_value.Text = co2 + "";
                    co2_emissions_text.Text = " gr / km";

                    co += 27.04 / 100;
                    co_emissions_value.Text = co + "";
                    co_emissions_text.Text = " gr / km";

                    nox += 19.63 / 100;
                    nox_emissions_value.Text = nox + "";
                    nox_emissions_text.Text = " gr / km";

                    thc += 3.06 / 100;
                    thc_emissions_value.Text = thc + "";
                    thc_emissions_text.Text = " gr / km";

                    global += 3.58 / 100;
                    global_warming_emissions_value.Text = global + "";
                    global_warming_emissions_text.Text = " kgr / km";
                }
                else
                {
                    co2 += 1935.16 / 100;
                    co2_emissions_value.Text = co2 + "";
                    co2_emissions_text.Text = " gr / km";

                    co += 13.36 / 100;
                    co_emissions_value.Text = co + "";
                    co_emissions_text.Text = " gr / km";

                    nox += 13.90 / 100;
                    nox_emissions_value.Text = nox + "";
                    nox_emissions_text.Text = " gr / km";

                    thc += 1.51 / 100;
                    thc_emissions_value.Text = thc + "";
                    thc_emissions_text.Text = " gr / km";

                    global += 2.33 / 100;
                    global_warming_emissions_value.Text = global + "";
                    global_warming_emissions_text.Text = " kgr / km";
                }

            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>Returns the local Resources directory</returns>
        private string getResDir()
        {
            
            DirectoryInfo dir = new DirectoryInfo(
            Directory.GetCurrentDirectory());
            while (dir != null && !dir.GetFiles("*.sln").Any())
            {
                dir = dir.Parent;
            }
            return Convert.ToString(dir.FullName + "\\k-agv-kids\\Resources\\");
            //ONLY FOR RELEASE
            //return Convert.ToString(Directory.GetCurrentDirectory() + "\\Resources\\");

        }
        private void init()
        {
            isRunning = false;
            isFirstRun = true;

            lb_orderme.Visible = false;
            lb_orderme.ForeColor = Color.Red;
            lb_orderme.Text = "Please send a command";
            orderme_timer.Interval = 300;
           
            pb_battery.Maximum = 100;
            pb_battery.Value = pb_battery.Maximum;
            groupBox1.Visible = false;
            Clipboard.Clear();

            
            //initialize picturebox's attributes

            //Carry button
            pb_lift.Image = Image.FromFile(getResDir() + "carry.png");
            pb_lift.SizeMode = PictureBoxSizeMode.StretchImage;

            //left button
            pb_left.Image = Image.FromFile(getResDir() + "arrow.png");
            pb_left.SizeMode = PictureBoxSizeMode.StretchImage;

            //down button
            pb_down.Image = Image.FromFile(getResDir() + "arrow.png");
            pb_down.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_down.Image.RotateFlip(RotateFlipType.Rotate90FlipY);

            //right button
            pb_right.Image = Image.FromFile(getResDir() + "arrow.png");
            pb_right.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_right.Image.RotateFlip(RotateFlipType.Rotate180FlipY);

            //up button
            pb_up.Image = Image.FromFile(getResDir() + "arrow.png");
            pb_up.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_up.Image.RotateFlip(RotateFlipType.Rotate90FlipX);

            //start/stop button
            pb_start.Image = Image.FromFile(getResDir() + "start.png");
            pb_start.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_start.Visible = false;

            //clone the event to buttons
            useArrows(true);


            //Richbox's backcolor.has to be same as picturebox's
            tb_commands.BackColor = game_panel.BackColor;



        }

        /// <summary>
        /// Draws the grid.
        /// </summary>
        /// <param name="grid_res">The grid resolution (Pixels)</param>
        private void drawGrid(int grid_res)
        {
            for_grid = game_panel.CreateGraphics();
            int a, b;

            //speed up the refresh animation rate by lowering grid's paint quality.
            //  !care
            for_grid.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.Bicubic;

            using (Pen gridPen = new Pen(Color.Black))
            {
                //Using -O3 optimization for For() loops
                for (a = 0; a < game_panel.Width; a += grid_res)
                {
                    for_grid.DrawLine(gridPen, a, 0, a, game_panel.Height);
                }

                for (b = 0; b < game_panel.Height; b += grid_res)
                {
                    for_grid.DrawLine(gridPen, 0, b, game_panel.Width, b);
                }
                //Watch out.Grid's size is 500+1,350+1...+1 because the known border bug
            }

            updateWarningState();

        }
        bool isCommandPressed=false;
        private void commandPressed(bool x)
        {
            isCommandPressed = x;
        }
        //overload the function
        private bool commandPressed()
        {
            if (isCommandPressed)
                return true;
            else
                return false;
        }
        private void cleanVars()
        {
            commands = "";
            orderme_time = 0;
            commandCounter = 0;
            animCounter = 0;
            commands_array = new char[500];
            array_counter = 0;
            Clipboard.Clear();
        }

        private void reset(bool fromWall)
        {
            //emissions reset
            co2 = 0;
            co = 0;
            nox = 0;
            thc = 0;
            global = 0;
            co2_emissions_value.Text = "null";
            co2_emissions_text.Text = "";
            co_emissions_text.Text = "";
            co_emissions_value.Text = "null";
            nox_emissions_text.Text = "";
            nox_emissions_value.Text = "null";
            thc_emissions_text.Text = "";
            thc_emissions_value.Text = "null";
            global_warming_emissions_text.Text = "";
            global_warming_emissions_value.Text = "null";
            low_fuel.Visible = false;

            loads_c = 0;
            obstacles_c = 0;

            //vehicles enabled
            batteryToolStripMenuItem.Enabled = true;
            petrolToolStripMenuItem.Enabled = true;
            lPGToolStripMenuItem.Enabled = true;

            //pb_battery bools
            pb_color_change = false;
            pb_color_change_next_step = false;

            cleanVars();

            orderme_time = 0;

            
            
            char[] commands_array = new char [500];
            
            isRunning = false;
            isFirstRun = true;
            obstacle_found = false;
            pb_start.Visible = false;

            //Reset to '0' to get prepared for new game
            score_label.Text = "0";
            lift_label.Text = "Waiting orders";
            warning = false;
            updateWarningState();
            //clear RichBox's commands
            tb_commands.Clear();

            //Empty the Clipboard...(A wild bug appeared)
            Clipboard.Clear();

            //Reset warning LED
            using (SolidBrush b = new SolidBrush(Color.Green))
            {
                for_warning.FillEllipse(b, 5, 5, 20, 20);
            }

            //Reset progress bars
           
            pbColorChanger.SetState(pb_battery, 1);
           
            //emission_status.Text = "emissions status";
            //emission_status.ForeColor = Color.Black;

            if (fromWall)
            {
                pb_start.Visible = true;
                useArrows(true);
                animCounter = 0;
            }
            else
            {
                pb_battery.Maximum = 100;
                pb_battery.Value = pb_battery.Maximum;
            }
           

        }
        private void updateWarningState()
        {
            warning_panel.BackColor = this.BackColor;
            for_warning = warning_panel.CreateGraphics();
            //add perfect quality to those graphics;
            for_warning.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            if (!warning)
            {
                using (SolidBrush b = new SolidBrush(Color.Green))
                {
                    for_warning.FillEllipse(b, 5, 5, 20, 20);
                }
            }
            else
            {
                using (SolidBrush b = new SolidBrush(Color.Red))
                {
                    for_warning.FillEllipse(b, 5, 5, 20, 20);
                }
            }
        }
        /*
         * Map file
         * --------
         * 0=clean block
         * 1=entrance
         * 2=exit
         * 3=wall
         * 4=load
         */

        /// <summary>
        /// Shows the map to panel.
        /// </summary>
        /// <param name="map">2D array of k-aGv map file</param>
        private void ShowMap(int[,] map)
        {
            agv = new PictureBox();
            Point _tempAGV = new Point((entrance_x * res_offset) + res_offset, (entrance_y * res_offset));
            agv.Location = _tempAGV;
            agv.BackColor = game_panel.BackColor;
            agv.BorderStyle = BorderStyle.FixedSingle;
            agv.SizeMode = PictureBoxSizeMode.StretchImage;
            agv.Size = new Size(res_offset + 1, res_offset + 1);
            agv.Visible = true;
            agv.Image = Image.FromFile(getResDir() + "empty.png");
            game_panel.Controls.Add(agv);

            for (int i = 0; i < map.GetLength(1); i++)
                for (int j = 0; j < map.GetLength(0); j++)
                {
                    if (map[j, i] != 0)
                    {
                        pb_array[array_counter] = new PictureBox();
                        Point _tempPoint = new Point(j * res_offset, i * res_offset);
                        pb_array[array_counter].BackColor = game_panel.BackColor;
                        pb_array[array_counter].BorderStyle = BorderStyle.FixedSingle;
                        pb_array[array_counter].Location = _tempPoint;
                        pb_array[array_counter].SizeMode = PictureBoxSizeMode.StretchImage;
                        pb_array[array_counter].Size = new Size(res_offset + 1, res_offset + 1); //+1 so the Picturebox borders will get on top of the grid lines
                        pb_array[array_counter].Visible = true;
                        if (map[j, i] == 1) //entrance
                        {
                            pb_array[array_counter].Name = "Entrance" + "_" + array_counter;
                            pb_array[array_counter].Image = Image.FromFile(getResDir() + "entrance.png");
                        }
                        else if (map[j, i] == 2) //exit
                        {
                            exitCounter = array_counter;
                            pb_array[array_counter].Name = "Exit" + "_" + array_counter;
                            pb_array[array_counter].Image = Image.FromFile(getResDir() + "exit.png");
                        }
                        else if (map[j, i] == 3) //wall
                        {
                            obstaclescounter[obstacles_c]=array_counter;
                            pb_array[array_counter].Name = "Wall" + "_" + array_counter;
                            pb_array[array_counter].Image = Image.FromFile(getResDir() + "wall.png");
                            obstacles_c++;
                        }
                        else if (map[j, i] == 4) //station
                        {
                            //detect in which block of array,the station is stored
                            stationCounter = array_counter;
                            pb_array[array_counter].Name = "Station";
                            pb_array[array_counter].Image = Image.FromFile(getResDir() + "station.png");
                        }
                        else //load
                        {
                            loads[loads_c] = 6;
                            loadscounter[loads_c] = array_counter;
                            pb_array[array_counter].Name = "Load" + "_" + array_counter;
                            pb_array[array_counter].Image = Image.FromFile(getResDir() + "loads-6.png");
                            loads_c++;
                        }

                        game_panel.Controls.Add(pb_array[array_counter]);
                        array_counter++;
                    }
                }
        }

        private bool checkForFuelStation(PictureBox AGV)
        {

            int tempX = AGV.Location.X;
            int tempy = AGV.Location.Y;
            //it could be done with a single if but i need things tided...
            
            //check if station is on the RIGHT block of agv
            if (AGV.Location.X + res_offset == pb_array[stationCounter].Location.X
                   && AGV.Location.Y == pb_array[stationCounter].Location.Y)
            {
                return true;
            }
            //check if station is on the LEFT block of agv
            else if (AGV.Location.X - res_offset == pb_array[stationCounter].Location.X
                   && AGV.Location.Y == pb_array[stationCounter].Location.Y)
            {
                return true;
            }
            //check if station is on the UPPER block of agv
            else if (AGV.Location.X == pb_array[stationCounter].Location.X
                  && AGV.Location.Y - res_offset == pb_array[stationCounter].Location.Y)
            {
                return true;
            }
            //check if station is on the BOTTOM block of agv
            else if (AGV.Location.X == pb_array[stationCounter].Location.X
                  && AGV.Location.Y + res_offset == pb_array[stationCounter].Location.Y)
            {
                return true;
            }
            //check if AGV is on the TOP RIGHT corner of the station
            else if (AGV.Location.X - res_offset == pb_array[stationCounter].Location.X
                  && AGV.Location.Y - res_offset == pb_array[stationCounter].Location.Y)
            {
                return true;
            }
            //check if AGV is on the TOP LEFT corner of the station
            else if (AGV.Location.X + res_offset == pb_array[stationCounter].Location.X
              && AGV.Location.Y - res_offset == pb_array[stationCounter].Location.Y)
            {
                return true;
            }
            //check if AGV is on the BOTTOM RIGHT corner of the station
            else if (AGV.Location.X - res_offset == pb_array[stationCounter].Location.X
              && AGV.Location.Y + res_offset == pb_array[stationCounter].Location.Y)
            {
                return true;
            }
            //check if AGV is on the BOTTOM LEFT corner of the station
            else if (AGV.Location.X + res_offset == pb_array[stationCounter].Location.X
              && AGV.Location.Y + res_offset == pb_array[stationCounter].Location.Y)
            {
                return true;
            }

            //else inform the debug message
            else
            {
                debug2.Text = "Not found";
                return false;
            }
            
        }
        private bool checkForObstacle(PictureBox AGV, int i, char direction)
        {
            int tempX = AGV.Location.X;
            int tempy = AGV.Location.Y;


            //check if obstacle is on the RIGHT block of agv
            if (direction == '>' && (AGV.Location.X + res_offset == pb_array[obstaclescounter[i]].Location.X
                   && AGV.Location.Y == pb_array[obstaclescounter[i]].Location.Y))
            {
                return true;
            }
            //check if obstacle is on the LEFT block of agv
            else if (direction == '<' && (AGV.Location.X - res_offset == pb_array[obstaclescounter[i]].Location.X
                   && AGV.Location.Y == pb_array[obstaclescounter[i]].Location.Y))
            {
                return true;
            }
            //check if obstacle is on the UPPER block of agv
            else if (direction == '^' && (AGV.Location.X == pb_array[obstaclescounter[i]].Location.X
                  && AGV.Location.Y - res_offset == pb_array[obstaclescounter[i]].Location.Y))
            {
                return true;
            }
            //check if obstacle is on the BOTTOM block of agv
            else if (direction == 'V' && (AGV.Location.X == pb_array[obstaclescounter[i]].Location.X
                  && AGV.Location.Y + res_offset == pb_array[obstaclescounter[i]].Location.Y))
            {
                return true;
            }
            else
                return false;

        }

        private bool checkForLoad(PictureBox AGV,int i)
        {
            int tempX = AGV.Location.X;
            int tempy = AGV.Location.Y;


            if (AGV.Location.X == pb_array[loadscounter[i]].Location.X &&
                AGV.Location.Y == pb_array[loadscounter[i]].Location.Y)
            {
                k = i;
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool checkForExit(PictureBox AGV)
        {
            int tempX = AGV.Location.X;
            int tempy = AGV.Location.Y;


            if (AGV.Location.X == pb_array[exitCounter].Location.X &&
                AGV.Location.Y == pb_array[exitCounter].Location.Y)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void loadsreduceby1(int index)
        {
            while (loads[index] > 0)
            {
                loads[index]-=2;
                debugloads.Text = loads[index].ToString();
                if(loads[index]!=0) 
                    pb_array[loadscounter[index]].Image = Image.FromFile(getResDir() +"loads-"+loads[index]+".png");
                break;
            }
            if (loads[index] == 0)
                pb_array[loadscounter[index]].Image = null;

        }
        private bool wantGetRefuelled()
        {
            anim_timer.Stop();
            debug2.Text = "Fuel Station Nearby";
            DialogResult choise = MessageBox.Show("AGV is next to fuel station\r\nRefuel?"
                                               , "Nearby fuel station!"
                                               , MessageBoxButtons.YesNo);
            if (choise == DialogResult.Yes)
            {
                return true;
            }
            else
            {
                anim_timer.Start();//restart time to continue the commands execution
                return false;
            }

        }
        private void getRefuelled()
        {
            seconds = 0; //if removed, refuel will keep counting reaching negative numbers (refuel will fail)
            refuel_timer.Start();

            pb_battery.Value = pb_battery.Maximum;
            low_fuel.Visible = false;
            pbColorChanger.SetState(pb_battery, 1);
            using (SolidBrush b = new SolidBrush(Color.Green))
            {
                for_warning.FillEllipse(b, 5, 5, 20, 20);
                warning = false;
            }
        }
       
        private bool isWallOnNextMove(char command)
        {
            if (command == '<')
            {
                if (agv.Location.X  == 0)
                {
                    reset(true);
                    return true;
                }
                else
                    return false;
            }
            if (command == '>')
            {
                if (agv.Location.X + res_offset + 1  == game_panel.Width)
                {
                    reset(true);
                    return true;
                }
                else
                    return false;
            }
            if (command == '^')
            {
                if (agv.Location.Y == 0)
                {
                    reset(true);
                    return true;
                }
                else
                    return false;
            }
            if (command == 'V')
            {
                if (agv.Location.Y + res_offset + 1 == game_panel.Height)
                {
                    reset(true);
                    return true;
                }
                else
                    return false;
            }
            return false;
            

          
        }
        private void useArrows(bool t)
        {
            if (t)
            {

                pb_right.MouseDown += new MouseEventHandler(pb_left_MouseDown);
                pb_right.MouseUp += new MouseEventHandler(pb_left_MouseUp);

                pb_up.MouseDown += new MouseEventHandler(pb_left_MouseDown);
                pb_up.MouseUp += new MouseEventHandler(pb_left_MouseUp);

                pb_down.MouseDown += new MouseEventHandler(pb_left_MouseDown);
                pb_down.MouseUp += new MouseEventHandler(pb_left_MouseUp);

                pb_lift.MouseDown += new MouseEventHandler(pb_left_MouseDown);
                pb_lift.MouseUp += new MouseEventHandler(pb_left_MouseUp);

                pb_start.MouseDown += new MouseEventHandler(pb_left_MouseDown);
                pb_start.MouseUp += new MouseEventHandler(pb_left_MouseUp);

            }
            else
            {
                pb_right.MouseDown -= new MouseEventHandler(pb_left_MouseDown);
                pb_right.MouseUp -= new MouseEventHandler(pb_left_MouseUp);

                pb_up.MouseDown -= new MouseEventHandler(pb_left_MouseDown);
                pb_up.MouseUp -= new MouseEventHandler(pb_left_MouseUp);

                pb_down.MouseDown -= new MouseEventHandler(pb_left_MouseDown);
                pb_down.MouseUp -= new MouseEventHandler(pb_left_MouseUp);

                pb_lift.MouseDown -= new MouseEventHandler(pb_left_MouseDown);
                pb_lift.MouseUp -= new MouseEventHandler(pb_left_MouseUp);

                pb_start.MouseDown -= new MouseEventHandler(pb_left_MouseDown);
                pb_start.MouseUp -= new MouseEventHandler(pb_left_MouseUp);
            }
        }

        //99% sorcery.Removes all controls drawn to panel.
        //nothing to explain here.dont expand!!!heartattack possibility
        private void removeControls(Control _c, Type _toBeRemoved)
        {
            List<Control> controlTemplate = new List<Control>();
            Stack<Control> _stack = new Stack<Control>();
            _stack.Push(_c);
            try
            {
                while (_stack.Count > 0)
                {
                    Control custom_control = _stack.Pop();
                    foreach (Control child in custom_control.Controls)
                    {
                        if (child.GetType() == _toBeRemoved)
                        {
                            controlTemplate.Add(child);
                        }
                        else if (true == child.HasChildren)
                        {
                            _stack.Push(child);
                        }
                    }

                }
            }
            catch (Exception e)
            {
                throw new errorFetchException("Stack overflow", e);

            } 
            foreach (Control custom_control in controlTemplate)
            {
                _c.Controls.Remove(custom_control);
                custom_control.Dispose();
            }
        }
        class errorFetchException : Exception
        {
            const string leak = "A wild memory leak appeared on your stack!";
            public errorFetchException(string msg, Exception _inner) :
                base(String.Format(msg, leak, _inner))
            {
                MessageBox.Show(this.Message);
            }
        }
        
    }
}
