namespace k_agv_kids
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chooseLevelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commandsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.batteryLevelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.levelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aGVStageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.levelEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.greekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.game_panel = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pb_lift = new System.Windows.Forms.PictureBox();
            this.pb_left = new System.Windows.Forms.PictureBox();
            this.pb_right = new System.Windows.Forms.PictureBox();
            this.pb_down = new System.Windows.Forms.PictureBox();
            this.pb_up = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.warning_panel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lift_label = new System.Windows.Forms.Label();
            this.lift_state = new System.Windows.Forms.Label();
            this.level_label = new System.Windows.Forms.Label();
            this.battery_label = new System.Windows.Forms.Label();
            this.score_label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_commands = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pb_start = new System.Windows.Forms.PictureBox();
            this.ofd_level = new System.Windows.Forms.OpenFileDialog();
            this.anim_timer = new System.Windows.Forms.Timer(this.components);
            this.load_timer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_lift)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_left)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_right)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_down)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_up)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_start)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(822, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem1,
            this.clearToolStripMenuItem,
            this.levelEditorToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.newGameToolStripMenuItem.Text = "Game";
            // 
            // newGameToolStripMenuItem1
            // 
            this.newGameToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.chooseLevelToolStripMenuItem,
            this.exportToolStripMenuItem});
            this.newGameToolStripMenuItem1.Name = "newGameToolStripMenuItem1";
            this.newGameToolStripMenuItem1.Size = new System.Drawing.Size(135, 22);
            this.newGameToolStripMenuItem1.Text = "New Game";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Enabled = false;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.newToolStripMenuItem.Text = "Start(Still a BETA)";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // chooseLevelToolStripMenuItem
            // 
            this.chooseLevelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5});
            this.chooseLevelToolStripMenuItem.Enabled = false;
            this.chooseLevelToolStripMenuItem.Name = "chooseLevelToolStripMenuItem";
            this.chooseLevelToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.chooseLevelToolStripMenuItem.Text = "Choose level(Still a BETA)";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(140, 22);
            this.toolStripMenuItem2.Text = "1 (Very easy)";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(140, 22);
            this.toolStripMenuItem3.Text = "2 (Easy)";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(140, 22);
            this.toolStripMenuItem4.Text = "3 (Normal)";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(140, 22);
            this.toolStripMenuItem5.Text = "4 (Hard)";
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.exportToolStripMenuItem.Text = "Import";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.importToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.commandsToolStripMenuItem,
            this.scoreToolStripMenuItem,
            this.batteryLevelToolStripMenuItem,
            this.levelToolStripMenuItem,
            this.aGVStageToolStripMenuItem,
            this.allToolStripMenuItem});
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            // 
            // commandsToolStripMenuItem
            // 
            this.commandsToolStripMenuItem.Name = "commandsToolStripMenuItem";
            this.commandsToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.commandsToolStripMenuItem.Text = "Commands";
            this.commandsToolStripMenuItem.Click += new System.EventHandler(this.commandsToolStripMenuItem_Click);
            // 
            // scoreToolStripMenuItem
            // 
            this.scoreToolStripMenuItem.Name = "scoreToolStripMenuItem";
            this.scoreToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.scoreToolStripMenuItem.Text = "Score";
            this.scoreToolStripMenuItem.Click += new System.EventHandler(this.scoreToolStripMenuItem_Click);
            // 
            // batteryLevelToolStripMenuItem
            // 
            this.batteryLevelToolStripMenuItem.Name = "batteryLevelToolStripMenuItem";
            this.batteryLevelToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.batteryLevelToolStripMenuItem.Text = "Battery Level";
            this.batteryLevelToolStripMenuItem.Click += new System.EventHandler(this.batteryLevelToolStripMenuItem_Click);
            // 
            // levelToolStripMenuItem
            // 
            this.levelToolStripMenuItem.Name = "levelToolStripMenuItem";
            this.levelToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.levelToolStripMenuItem.Text = "Level";
            this.levelToolStripMenuItem.Click += new System.EventHandler(this.levelToolStripMenuItem_Click);
            // 
            // aGVStageToolStripMenuItem
            // 
            this.aGVStageToolStripMenuItem.Name = "aGVStageToolStripMenuItem";
            this.aGVStageToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.aGVStageToolStripMenuItem.Text = "AGV Stage";
            this.aGVStageToolStripMenuItem.Click += new System.EventHandler(this.aGVStageToolStripMenuItem_Click);
            // 
            // allToolStripMenuItem
            // 
            this.allToolStripMenuItem.Name = "allToolStripMenuItem";
            this.allToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.allToolStripMenuItem.Text = "All";
            this.allToolStripMenuItem.Click += new System.EventHandler(this.allToolStripMenuItem_Click);
            // 
            // levelEditorToolStripMenuItem
            // 
            this.levelEditorToolStripMenuItem.Name = "levelEditorToolStripMenuItem";
            this.levelEditorToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.levelEditorToolStripMenuItem.Text = "Level Editor";
            this.levelEditorToolStripMenuItem.Click += new System.EventHandler(this.levelEditorToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.languageToolStripMenuItem});
            this.optionsToolStripMenuItem.Enabled = false;
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // languageToolStripMenuItem
            // 
            this.languageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.greekToolStripMenuItem,
            this.englishToolStripMenuItem});
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            this.languageToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.languageToolStripMenuItem.Text = "Language";
            // 
            // greekToolStripMenuItem
            // 
            this.greekToolStripMenuItem.Name = "greekToolStripMenuItem";
            this.greekToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.greekToolStripMenuItem.Text = "Greek";
            // 
            // englishToolStripMenuItem
            // 
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            this.englishToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.englishToolStripMenuItem.Text = "English";
            // 
            // game_panel
            // 
            this.game_panel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.game_panel.Location = new System.Drawing.Point(13, 28);
            this.game_panel.Name = "game_panel";
            this.game_panel.Size = new System.Drawing.Size(501, 351);
            this.game_panel.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pb_lift);
            this.groupBox1.Controls.Add(this.pb_left);
            this.groupBox1.Controls.Add(this.pb_right);
            this.groupBox1.Controls.Add(this.pb_down);
            this.groupBox1.Controls.Add(this.pb_up);
            this.groupBox1.Location = new System.Drawing.Point(539, 182);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(176, 169);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Controls";
            // 
            // pb_lift
            // 
            this.pb_lift.Location = new System.Drawing.Point(54, 61);
            this.pb_lift.Name = "pb_lift";
            this.pb_lift.Size = new System.Drawing.Size(69, 57);
            this.pb_lift.TabIndex = 1;
            this.pb_lift.TabStop = false;
            // 
            // pb_left
            // 
            this.pb_left.Location = new System.Drawing.Point(6, 70);
            this.pb_left.Name = "pb_left";
            this.pb_left.Size = new System.Drawing.Size(42, 39);
            this.pb_left.TabIndex = 0;
            this.pb_left.TabStop = false;
            this.pb_left.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pb_left_MouseDown);
            this.pb_left.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pb_left_MouseUp);
            // 
            // pb_right
            // 
            this.pb_right.Location = new System.Drawing.Point(129, 70);
            this.pb_right.Name = "pb_right";
            this.pb_right.Size = new System.Drawing.Size(42, 39);
            this.pb_right.TabIndex = 0;
            this.pb_right.TabStop = false;
            // 
            // pb_down
            // 
            this.pb_down.Location = new System.Drawing.Point(65, 124);
            this.pb_down.Name = "pb_down";
            this.pb_down.Size = new System.Drawing.Size(42, 39);
            this.pb_down.TabIndex = 0;
            this.pb_down.TabStop = false;
            // 
            // pb_up
            // 
            this.pb_up.Location = new System.Drawing.Point(65, 15);
            this.pb_up.Name = "pb_up";
            this.pb_up.Size = new System.Drawing.Size(42, 39);
            this.pb_up.TabIndex = 0;
            this.pb_up.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.warning_panel);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lift_label);
            this.groupBox2.Controls.Add(this.lift_state);
            this.groupBox2.Controls.Add(this.level_label);
            this.groupBox2.Controls.Add(this.battery_label);
            this.groupBox2.Controls.Add(this.score_label);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(520, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(225, 148);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Score and stats";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(107, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "%";
            // 
            // warning_panel
            // 
            this.warning_panel.BackColor = System.Drawing.SystemColors.ControlText;
            this.warning_panel.Location = new System.Drawing.Point(165, 51);
            this.warning_panel.Name = "warning_panel";
            this.warning_panel.Size = new System.Drawing.Size(30, 30);
            this.warning_panel.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(145, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Warning state";
            // 
            // lift_label
            // 
            this.lift_label.AutoSize = true;
            this.lift_label.Location = new System.Drawing.Point(78, 119);
            this.lift_label.Name = "lift_label";
            this.lift_label.Size = new System.Drawing.Size(10, 13);
            this.lift_label.TabIndex = 5;
            this.lift_label.Text = "-";
            // 
            // lift_state
            // 
            this.lift_state.AutoSize = true;
            this.lift_state.Location = new System.Drawing.Point(7, 119);
            this.lift_state.Name = "lift_state";
            this.lift_state.Size = new System.Drawing.Size(50, 13);
            this.lift_state.TabIndex = 4;
            this.lift_state.Text = "Lift state:";
            // 
            // level_label
            // 
            this.level_label.AutoSize = true;
            this.level_label.Location = new System.Drawing.Point(78, 95);
            this.level_label.Name = "level_label";
            this.level_label.Size = new System.Drawing.Size(13, 13);
            this.level_label.TabIndex = 3;
            this.level_label.Text = "0";
            // 
            // battery_label
            // 
            this.battery_label.AutoSize = true;
            this.battery_label.Location = new System.Drawing.Point(78, 68);
            this.battery_label.Name = "battery_label";
            this.battery_label.Size = new System.Drawing.Size(13, 13);
            this.battery_label.TabIndex = 3;
            this.battery_label.Text = "0";
            // 
            // score_label
            // 
            this.score_label.AutoSize = true;
            this.score_label.Location = new System.Drawing.Point(78, 42);
            this.score_label.Name = "score_label";
            this.score_label.Size = new System.Drawing.Size(13, 13);
            this.score_label.TabIndex = 3;
            this.score_label.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Level:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Battery Level:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Score:";
            // 
            // tb_commands
            // 
            this.tb_commands.Location = new System.Drawing.Point(751, 51);
            this.tb_commands.Name = "tb_commands";
            this.tb_commands.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.tb_commands.Size = new System.Drawing.Size(60, 261);
            this.tb_commands.TabIndex = 0;
            this.tb_commands.TabStop = false;
            this.tb_commands.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(752, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Commands";
            // 
            // pb_start
            // 
            this.pb_start.Location = new System.Drawing.Point(751, 319);
            this.pb_start.Name = "pb_start";
            this.pb_start.Size = new System.Drawing.Size(60, 60);
            this.pb_start.TabIndex = 5;
            this.pb_start.TabStop = false;
            // 
            // ofd_level
            // 
            this.ofd_level.FileName = "openFileDialog1";
            // 
            // anim_timer
            // 
            this.anim_timer.Interval = 500;
            this.anim_timer.Tick += new System.EventHandler(this.anim_timer_Tick);
            // 
            // load_timer
            // 
            this.load_timer.Interval = 500;
            this.load_timer.Tick += new System.EventHandler(this.load_timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 400);
            this.Controls.Add(this.pb_start);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_commands);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.game_panel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_lift)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_left)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_right)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_down)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_up)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_start)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Panel game_panel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pb_left;
        private System.Windows.Forms.PictureBox pb_right;
        private System.Windows.Forms.PictureBox pb_down;
        private System.Windows.Forms.PictureBox pb_up;
        private System.Windows.Forms.PictureBox pb_lift;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label level_label;
        private System.Windows.Forms.Label battery_label;
        private System.Windows.Forms.Label score_label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lift_label;
        private System.Windows.Forms.Label lift_state;
        private System.Windows.Forms.Panel warning_panel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox tb_commands;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem commandsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem batteryLevelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem levelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aGVStageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allToolStripMenuItem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chooseLevelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem greekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.PictureBox pb_start;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem levelEditorToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog ofd_level;
        private System.Windows.Forms.Timer anim_timer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer load_timer;
    }
}

