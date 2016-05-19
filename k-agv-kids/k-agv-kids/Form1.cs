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

        int grid_res=50;//levels should have a random resolution 

        int[,] map;

        int width_blocks,height_blocks,res_offset;

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
            else if ((sender as PictureBox).Name == "pb_lift")
            {
                pb_backcolor = pb_left.BackColor;
                pb_lift.BackColor = Color.Gray;

                Clipboard.Clear();//Empty the clipboard
                _tempImage = new Bitmap(pb_lift.Image, new Size(25, 25));//create new image based on PB's one
                Clipboard.SetImage(_tempImage); //Set it to Clipboard
                tb_commands.Paste(); //Paste it to RichBox
            }
            else //pb_start
            {
                if (isRunning)
                {
                    pb_start.Image = Image.FromFile(getResDir() + "start.png");
                    isRunning = !isRunning;
                }
                else
                {
                    pb_start.Image = Image.FromFile(getResDir() + "pause.png");
                    isRunning = !isRunning;
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
            StartFromLevel_1();
        }

        private void levelEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Run the editor
        }

       

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            if (ofd_level.ShowDialog() == DialogResult.OK)
            {
                StreamReader reader = new StreamReader(ofd_level.FileName);
                reader.ReadLine();//read the first line "Map Info:"
                string map_details = reader.ReadLine(); //second line are the map's details
               
                //Start second line's split
                char[] delim = {' '};
                string[] words = map_details.Split(delim);

                bool isNumber;
                int _tempNumber;
                int whichNumber=1;
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
                        }
                      
                    }
                }
                //End of data import

               /*debug
                *MessageBox.Show(width_blocks + " " + height_blocks + " " + res_offset);
                */

                //skip the 3rd line
                reader.ReadLine();

                //create the map array
                map = new int[width_blocks, height_blocks];

                //parse the map
                //prepare the delims to get coords

                //char[] delim = { ' ' };
                words = reader.ReadLine().Split(delim);

                for (int z = 0; z < map.GetLength(1); z++)
                {
                    for (int i = 0; i < map.GetLength(0); i++)
                    {
                        foreach (string _s in words)
                        {
                            //MessageBox.Show(_s);
                            map[i, z] = Convert.ToInt32(_s);
                            MessageBox.Show(map[i, z] + "");
                        }
                        
                    }
                    //debug crashes after the read of the 1st line.(Reads empty string from file.missing var?)
                    words = reader.ReadLine().Split(delim);
                }


                


            }
        }
        
    }
}
