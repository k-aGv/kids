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

            //clone the event to buttons
            pb_right.MouseDown += new MouseEventHandler(pb_left_MouseDown);
            pb_right.MouseUp += new MouseEventHandler(pb_left_MouseUp);

            pb_up.MouseDown += new MouseEventHandler(pb_left_MouseDown);
            pb_up.MouseUp += new MouseEventHandler(pb_left_MouseUp);

            pb_down.MouseDown += new MouseEventHandler(pb_left_MouseDown);
            pb_down.MouseUp += new MouseEventHandler(pb_left_MouseUp);

            pb_lift.MouseDown += new MouseEventHandler(pb_left_MouseDown);
            pb_lift.MouseUp += new MouseEventHandler(pb_left_MouseUp);

            //Richbox's backcolor.has to be same as picturebox's
            tb_commands.BackColor = game_panel.BackColor;

            //Create the grid.
            drawGrid();
            

        }
        private void drawGrid()
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
        private void reset()
        {
           
            //Reset to '0' to get prepared for new game
            score_label.Text = "0";
            battery_label.Text = "100%";
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
    }
}
