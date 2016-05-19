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
        bool isRunning = false;
        private string getResDir()
        {
            DirectoryInfo dir = new DirectoryInfo(
            Directory.GetCurrentDirectory());
            while (dir != null && !dir.GetFiles("*.sln").Any())
            {
                dir = dir.Parent;
            }
            return Convert.ToString(dir.FullName+"\\k-agv-kids\\Resources\\");
        }
        private void init()
        {
            isRunning = false;
            //initialize picturebox's attributes

            //Carry button
            pb_lift.Image = Image.FromFile(getResDir() + "carry.png");
            pb_lift.SizeMode = PictureBoxSizeMode.StretchImage;

            //left button
            pb_left.Image = Image.FromFile(getResDir() + "arrow.png");
            pb_left.SizeMode = PictureBoxSizeMode.StretchImage;

            //down button
            pb_down.Image=Image.FromFile(getResDir()+ "arrow.png");
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


            //Richbox's backcolor.has to be same as picturebox's
            tb_commands.BackColor = game_panel.BackColor;

            //Create the grid.
            //drawGrid(50);
            

        }
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

            
            
            
          /*  Point _tempAGV = new Point(grid_res, 0);
            agv.Location = _tempAGV;
            agv.BackColor = game_panel.BackColor;
            agv.BorderStyle = BorderStyle.FixedSingle;
            agv.SizeMode = PictureBoxSizeMode.StretchImage;
            agv.Size = new Size(res_offset + 1, res_offset + 1); 
            agv.Visible = true;
            agv.Image = Image.FromFile(getResDir() + "empty.png");
            game_panel.Controls.Add(agv);
            
            */
            updateWarningState();

        }
        private void reset()
        {
            //reset commands
            commands = "";

            pb_start.Visible = false;

            //Reset to '0' to get prepared for new game
            score_label.Text = "0";
            battery_label.Text = "100";
            level_label.Text = "1";
            lift_label.Text = "Waiting orders";

            updateWarningState();
            //clear RichBox's commands
            tb_commands.Clear();

            //Empty the Clipboard...(A wild bug appeared)
            Clipboard.Clear();
        }
        private void updateWarningState()
        {
            warning_panel.BackColor = this.BackColor;
            for_warning = warning_panel.CreateGraphics();
            //add perfect quality to those graphics;
            for_warning.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            using (SolidBrush b = new SolidBrush(Color.Green))
            {
                for_warning.FillEllipse(b, 5, 5, 20, 20);
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
        private void ShowMap(int[,] map)
        {
            Point _tempAGV = new Point(grid_res, 0);
            agv.Location = _tempAGV;
            agv.BackColor = game_panel.BackColor;
            agv.BorderStyle = BorderStyle.FixedSingle;
            agv.SizeMode = PictureBoxSizeMode.StretchImage;
            agv.Size = new Size(res_offset + 1, res_offset + 1);
            agv.Visible = true;
            agv.Image = Image.FromFile(getResDir() + "empty.png");
            game_panel.Controls.Add(agv);

            for(int i=0;i<map.GetLength(1);i++)
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
                        pb_array[array_counter].Size = new Size(res_offset+1, res_offset+1); //+1 so the Picturebox borders will get on top of the grid lines
                        pb_array[array_counter].Visible = true;
                        if (map[j, i] == 1) //entrance
                        {
                            pb_array[array_counter].Name = "Entrance" + "_" + array_counter;
                            pb_array[array_counter].Image = Image.FromFile(getResDir() + "entrance.png");
                        }
                        else if (map[j, i] == 2) //exit
                        {
                            pb_array[array_counter].Name = "Exit" + "_" + array_counter;
                            pb_array[array_counter].Image = Image.FromFile(getResDir() + "exit.png");
                        }
                        else if (map[j, i] == 3) //wall
                        {
                            pb_array[array_counter].Name = "Wall" + "_" + array_counter;
                            pb_array[array_counter].Image = Image.FromFile(getResDir() + "wallobst.png");
                        }
                        else //load
                        {
                            pb_array[array_counter].Name = "Load" + "_" + array_counter;
                            pb_array[array_counter].Image = Image.FromFile(getResDir() + "loads.png");
                        }

                        game_panel.Controls.Add(pb_array[array_counter]);
                        array_counter++;
                    }
                }
        }

        //99% sorcery
        private void removeControls(Control _c, Type _toBeRemoved)
        {
            List<Control> controlTemplate = new List<Control>();
            Stack<Control> _stack = new Stack<Control>();
            _stack.Push(_c);
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
            foreach (Control custom_control in controlTemplate)
            {
                _c.Controls.Remove(custom_control);
                custom_control.Dispose();
            }
        }


    }
}
