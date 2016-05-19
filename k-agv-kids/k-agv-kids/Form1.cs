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

namespace k_agv_kids
{
    public partial class Form1 : Form
    {
        Graphics for_warning;
        Graphics for_grid;
        
        Color pb_backcolor;
        Bitmap _tempImage;

        PictureBox agv = new PictureBox();
        PictureBox[] pb_array=new PictureBox[100];
        int array_counter=0;
        bool isLoaded = false;
        char[] commands_array;

        int grid_res=50;//levels should have a random resolution 

        int[,] map;
        int entrance_x, entrance_y;

        int width_blocks,height_blocks,res_offset;
        string commands = "";
        int commandCounter = 0;
        Point tempLocation = new Point(0, 0);
        int animCounter = 0;

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
                commands += "<";//add the command to our 'command vault'
                commandCounter++;
            }
            else if ((sender as PictureBox).Name == "pb_right")
            {
                pb_backcolor = pb_left.BackColor;
                pb_right.BackColor = Color.Gray;

                Clipboard.Clear();//Empty the clipboard
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

                Clipboard.Clear();//Empty the clipboard
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

                Clipboard.Clear();//Empty the clipboard
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

                Clipboard.Clear();//Empty the clipboard
                _tempImage = new Bitmap(pb_lift.Image, new Size(25, 25));//create new image based on PB's one
                Clipboard.SetImage(_tempImage); //Set it to Clipboard
                tb_commands.Paste(); //Paste it to RichBox
                commands += "L";//add the command to our 'command vault'
                commandCounter++;
            }
            else //pb_start
            {
                isRunning = !isRunning;
                if (isRunning)
                {
                    pb_start.Image = Image.FromFile(getResDir() + "start.png");
                    commands_array = new char[commandCounter];
                    commands_array = commands.ToCharArray();
                    /*debug
                    for (int i = 0; i < commandCounter; i++)
                    {
                        MessageBox.Show(commands_array[i]+"");
                    }
                     */
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

        private void batteryLevelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            battery_label.Text = "0";
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
            reset();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reset();
            drawGrid(grid_res);
            //StartFromLevel_1();
        }

        private void levelEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Run the editor.RELEASE ONLY
            //Process.Start(Directory.GetCurrentDirectory() + "\\editor.exe");
            MessageBox.Show("This feature is working only on release version.\r\nPlease build from scratch.");
        }

       /*
        static string GetMd5Hash(MD5 md5Hash, string input)
        {

            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }

        // Verify a hash against a string.
        static bool VerifyMd5Hash(MD5 md5Hash, string input, string hash)
        {
            // Hash the input.
            string hashOfInput = GetMd5Hash(md5Hash, input);

            // Create a StringComparer an compare the hashes.
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;

            if (0 == comparer.Compare(hashOfInput, hash))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        */
        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reset();
            
            ofd_level.Filter = "k-aGv Map (*.kmap)|*.kmap";
            ofd_level.FileName = "";
            level_label.Text = "Custom level";

            if (ofd_level.ShowDialog() == DialogResult.OK)
            {
                /*
                StreamReader _r = new StreamReader(ofd_level.FileName+".md5");
                string hash = _r.ReadLine();
                using (MD5 md5hash = MD5.Create())
                {
                    string source = GetMd5Hash(md5hash, ofd_level.FileName);
                    if (VerifyMd5Hash(md5hash, source,hash))
                    {
                        MessageBox.Show("same");
                    }
                    else
                        MessageBox.Show("no");
                }
                _r.Close();
                */

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

               
                words = reader.ReadLine().Split(delim);
                
                for (int z = 0; z < map.GetLength(1); z++)
                {
                    
                    int i = 0;
                    foreach (string _s in words)
                    {
                        //MessageBox.Show(_s);
                        map[i, z] = Convert.ToInt32(_s);
                        if (Convert.ToInt32(_s) == 1)
                        {
                            entrance_x = i;
                            entrance_y = z;
                        }
                        i++;
                        //MessageBox.Show("" + map[i, z]);
                    }
                    if (z == map.GetLength(1) - 1)
                    { } //no break = error when trying to read the map.getlenght(1) line
                    
                    else
                        words = reader.ReadLine().Split(delim);
                }
                //MessageBox.Show("Finished import");
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
                anim_timer.Stop();
            }
            else
            {
                battery_label.Text = Convert.ToString(Convert.ToInt32(battery_label.Text) - 5) ;
                score_label.Text = Convert.ToString(Convert.ToInt32(score_label.Text) + 10);
                if (commands_array[animCounter] == '<')
                {
                    tempLocation = new Point(agv.Location.X - res_offset, agv.Location.Y);
                    agv.Location = tempLocation;
                    drawGrid(res_offset);
                    
                }
                else if (commands_array[animCounter] == '>')
                {
                    tempLocation = new Point(agv.Location.X + res_offset, agv.Location.Y);
                    agv.Location = tempLocation;
                    drawGrid(res_offset);
                    
                }
                else if (commands_array[animCounter] == 'V')
                {
                    tempLocation = new Point(agv.Location.X, agv.Location.Y + res_offset);
                    agv.Location = tempLocation;
                    drawGrid(res_offset);
                }
                else if (commands_array[animCounter] == '^')
                {
                    tempLocation = new Point(agv.Location.X, agv.Location.Y - res_offset);
                    agv.Location = tempLocation;
                    drawGrid(res_offset);
                   
                }
                else //lift
                {
                    agv.Image = Image.FromFile(getResDir() + "half.png");
                    load_timer.Start();
                    anim_timer.Stop();
                   
                }
                animCounter++;
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

     
       
        
    }
}
