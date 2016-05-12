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
        Graphics for_warning;
        Graphics for_grid;

        Color pb_backcolor;
        Bitmap _tempImage;

        int grid_res=10;//levels should have a random resolution 

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
        }

        private void pb_left_MouseDown(object sender, MouseEventArgs e)
        {
            //Tricky way to detect which button pressed
            if ((sender as PictureBox).Name == "pb_left")
            {
                pb_backcolor = pb_left.BackColor;
                pb_left.BackColor = Color.Gray;

                Clipboard.Clear();//Empty the clipboard
                _tempImage = new Bitmap(pb_left.Image, new Size(25, 25));//create new image based on PB's one
                Clipboard.SetImage(_tempImage); //Set it to Clipboard
                tb_commands.Paste(); //Paste it to RichBox
            }
            else if ((sender as PictureBox).Name == "pb_right")
            {
                pb_backcolor = pb_left.BackColor;
                pb_right.BackColor = Color.Gray;

                Clipboard.Clear();//Empty the clipboard
                _tempImage = new Bitmap(pb_right.Image, new Size(25, 25));//create new image based on PB's one
                Clipboard.SetImage(_tempImage); //Set it to Clipboard
                tb_commands.Paste(); //Paste it to RichBox
            }
            else if ((sender as PictureBox).Name == "pb_up")
            {
                pb_backcolor = pb_left.BackColor;
                pb_up.BackColor = Color.Gray;

                Clipboard.Clear();//Empty the clipboard
                _tempImage = new Bitmap(pb_up.Image, new Size(25, 25));//create new image based on PB's one
                Clipboard.SetImage(_tempImage); //Set it to Clipboard
                tb_commands.Paste(); //Paste it to RichBox
            }
            else if ((sender as PictureBox).Name == "pb_down")
            {
                pb_backcolor = pb_left.BackColor;
                pb_down.BackColor = Color.Gray;

                Clipboard.Clear();//Empty the clipboard
                _tempImage = new Bitmap(pb_down.Image, new Size(25, 25));//create new image based on PB's one
                Clipboard.SetImage(_tempImage); //Set it to Clipboard
                tb_commands.Paste(); //Paste it to RichBox
            }
            else //lift
            {
                pb_backcolor = pb_left.BackColor;
                pb_lift.BackColor = Color.Gray;

                Clipboard.Clear();//Empty the clipboard
                _tempImage = new Bitmap(pb_lift.Image, new Size(25, 25));//create new image based on PB's one
                Clipboard.SetImage(_tempImage); //Set it to Clipboard
                tb_commands.Paste(); //Paste it to RichBox
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

        private void batteryLevelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            battery_label.Text = "0%";
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
            //Clear panel + 
            reset();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reset();
            drawGrid();
        }
        
    }
}
