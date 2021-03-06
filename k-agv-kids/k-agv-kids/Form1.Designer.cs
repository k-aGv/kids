﻿namespace k_agv_kids
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
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commandsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vehicleTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.batteryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.petrolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lPGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.warning_panel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lift_label = new System.Windows.Forms.Label();
            this.lift_state = new System.Windows.Forms.Label();
            this.score_label = new System.Windows.Forms.Label();
            this.lb_steps = new System.Windows.Forms.Label();
            this.tb_commands = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pb_start = new System.Windows.Forms.PictureBox();
            this.ofd_level = new System.Windows.Forms.OpenFileDialog();
            this.anim_timer = new System.Windows.Forms.Timer(this.components);
            this.load_timer = new System.Windows.Forms.Timer(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.low_fuel = new System.Windows.Forms.Label();
            this.global_warming_emissions_text = new System.Windows.Forms.Label();
            this.thc_emissions_text = new System.Windows.Forms.Label();
            this.nox_emissions_text = new System.Windows.Forms.Label();
            this.co_emissions_text = new System.Windows.Forms.Label();
            this.co2_emissions_text = new System.Windows.Forms.Label();
            this.global_warming_emissions_value = new System.Windows.Forms.Label();
            this.thc_emissions_value = new System.Windows.Forms.Label();
            this.nox_emissions_value = new System.Windows.Forms.Label();
            this.global_warming_eq = new System.Windows.Forms.Label();
            this.emissions_THC = new System.Windows.Forms.Label();
            this.emissions_NOx = new System.Windows.Forms.Label();
            this.co_emissions_value = new System.Windows.Forms.Label();
            this.co2_emissions_value = new System.Windows.Forms.Label();
            this.type = new System.Windows.Forms.Label();
            this.vehicle_type = new System.Windows.Forms.Label();
            this.emissions_co = new System.Windows.Forms.Label();
            this.emissions_co2 = new System.Windows.Forms.Label();
            this.type_label = new System.Windows.Forms.Label();
            this.pb_battery = new System.Windows.Forms.ProgressBar();
            this.emission_status = new System.Windows.Forms.Label();
            this.lb_orderme = new System.Windows.Forms.Label();
            this.orderme_timer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_lift)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_left)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_right)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_down)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_up)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_start)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1025, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem1,
            this.clearToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.newGameToolStripMenuItem.Text = "Start";
            // 
            // newGameToolStripMenuItem1
            // 
            this.newGameToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToolStripMenuItem});
            this.newGameToolStripMenuItem1.Name = "newGameToolStripMenuItem1";
            this.newGameToolStripMenuItem1.Size = new System.Drawing.Size(101, 22);
            this.newGameToolStripMenuItem1.Text = "New";
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.exportToolStripMenuItem.Text = "Import";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.importToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.commandsToolStripMenuItem,
            this.scoreToolStripMenuItem,
            this.allToolStripMenuItem});
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            // 
            // commandsToolStripMenuItem
            // 
            this.commandsToolStripMenuItem.Name = "commandsToolStripMenuItem";
            this.commandsToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.commandsToolStripMenuItem.Text = "Commands";
            this.commandsToolStripMenuItem.Click += new System.EventHandler(this.commandsToolStripMenuItem_Click);
            // 
            // scoreToolStripMenuItem
            // 
            this.scoreToolStripMenuItem.Name = "scoreToolStripMenuItem";
            this.scoreToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.scoreToolStripMenuItem.Text = "Score";
            this.scoreToolStripMenuItem.Click += new System.EventHandler(this.scoreToolStripMenuItem_Click);
            // 
            // allToolStripMenuItem
            // 
            this.allToolStripMenuItem.Name = "allToolStripMenuItem";
            this.allToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.allToolStripMenuItem.Text = "All";
            this.allToolStripMenuItem.Click += new System.EventHandler(this.allToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vehicleTypeToolStripMenuItem,
            this.languageToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // vehicleTypeToolStripMenuItem
            // 
            this.vehicleTypeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.batteryToolStripMenuItem,
            this.petrolToolStripMenuItem,
            this.lPGToolStripMenuItem});
            this.vehicleTypeToolStripMenuItem.Name = "vehicleTypeToolStripMenuItem";
            this.vehicleTypeToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.vehicleTypeToolStripMenuItem.Text = "Vehicle Type";
            // 
            // batteryToolStripMenuItem
            // 
            this.batteryToolStripMenuItem.Checked = true;
            this.batteryToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.batteryToolStripMenuItem.Name = "batteryToolStripMenuItem";
            this.batteryToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.batteryToolStripMenuItem.Text = "Battery";
            this.batteryToolStripMenuItem.Click += new System.EventHandler(this.batteryToolStripMenuItem_Click);
            // 
            // petrolToolStripMenuItem
            // 
            this.petrolToolStripMenuItem.Name = "petrolToolStripMenuItem";
            this.petrolToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.petrolToolStripMenuItem.Text = "Petrol";
            this.petrolToolStripMenuItem.Click += new System.EventHandler(this.petrolToolStripMenuItem_Click);
            // 
            // lPGToolStripMenuItem
            // 
            this.lPGToolStripMenuItem.Name = "lPGToolStripMenuItem";
            this.lPGToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.lPGToolStripMenuItem.Text = "LPG";
            this.lPGToolStripMenuItem.Click += new System.EventHandler(this.lPGToolStripMenuItem_Click);
            // 
            // languageToolStripMenuItem
            // 
            this.languageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.greekToolStripMenuItem,
            this.englishToolStripMenuItem});
            this.languageToolStripMenuItem.Enabled = false;
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            this.languageToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
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
            this.game_panel.Location = new System.Drawing.Point(257, 25);
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
            this.groupBox1.Location = new System.Drawing.Point(764, 84);
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
            this.groupBox2.Controls.Add(this.warning_panel);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lift_label);
            this.groupBox2.Controls.Add(this.lift_state);
            this.groupBox2.Controls.Add(this.score_label);
            this.groupBox2.Controls.Add(this.lb_steps);
            this.groupBox2.Location = new System.Drawing.Point(12, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(225, 95);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Score and stats";
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
            this.lift_label.Location = new System.Drawing.Point(78, 68);
            this.lift_label.Name = "lift_label";
            this.lift_label.Size = new System.Drawing.Size(10, 13);
            this.lift_label.TabIndex = 5;
            this.lift_label.Text = "-";
            // 
            // lift_state
            // 
            this.lift_state.AutoSize = true;
            this.lift_state.Location = new System.Drawing.Point(7, 68);
            this.lift_state.Name = "lift_state";
            this.lift_state.Size = new System.Drawing.Size(50, 13);
            this.lift_state.TabIndex = 4;
            this.lift_state.Text = "Lift state:";
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
            // lb_steps
            // 
            this.lb_steps.AutoSize = true;
            this.lb_steps.Location = new System.Drawing.Point(7, 42);
            this.lb_steps.Name = "lb_steps";
            this.lb_steps.Size = new System.Drawing.Size(32, 13);
            this.lb_steps.TabIndex = 0;
            this.lb_steps.Text = "Step:";
            // 
            // tb_commands
            // 
            this.tb_commands.Location = new System.Drawing.Point(946, 43);
            this.tb_commands.Name = "tb_commands";
            this.tb_commands.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.tb_commands.Size = new System.Drawing.Size(60, 261);
            this.tb_commands.TabIndex = 0;
            this.tb_commands.TabStop = false;
            this.tb_commands.Text = "";
            this.tb_commands.TextChanged += new System.EventHandler(this.tb_commands_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(943, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Commands";
            // 
            // pb_start
            // 
            this.pb_start.Location = new System.Drawing.Point(946, 310);
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
            this.anim_timer.Interval = 300;
            this.anim_timer.Tick += new System.EventHandler(this.anim_timer_Tick);
            // 
            // load_timer
            // 
            this.load_timer.Interval = 500;
            this.load_timer.Tick += new System.EventHandler(this.load_timer_Tick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.low_fuel);
            this.groupBox3.Controls.Add(this.global_warming_emissions_text);
            this.groupBox3.Controls.Add(this.thc_emissions_text);
            this.groupBox3.Controls.Add(this.nox_emissions_text);
            this.groupBox3.Controls.Add(this.co_emissions_text);
            this.groupBox3.Controls.Add(this.co2_emissions_text);
            this.groupBox3.Controls.Add(this.global_warming_emissions_value);
            this.groupBox3.Controls.Add(this.thc_emissions_value);
            this.groupBox3.Controls.Add(this.nox_emissions_value);
            this.groupBox3.Controls.Add(this.global_warming_eq);
            this.groupBox3.Controls.Add(this.emissions_THC);
            this.groupBox3.Controls.Add(this.emissions_NOx);
            this.groupBox3.Controls.Add(this.co_emissions_value);
            this.groupBox3.Controls.Add(this.co2_emissions_value);
            this.groupBox3.Controls.Add(this.type);
            this.groupBox3.Controls.Add(this.vehicle_type);
            this.groupBox3.Controls.Add(this.emissions_co);
            this.groupBox3.Controls.Add(this.emissions_co2);
            this.groupBox3.Controls.Add(this.type_label);
            this.groupBox3.Controls.Add(this.pb_battery);
            this.groupBox3.Location = new System.Drawing.Point(12, 171);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(225, 199);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Vehicle status";
            // 
            // low_fuel
            // 
            this.low_fuel.AutoSize = true;
            this.low_fuel.Location = new System.Drawing.Point(132, 37);
            this.low_fuel.Name = "low_fuel";
            this.low_fuel.Size = new System.Drawing.Size(0, 13);
            this.low_fuel.TabIndex = 16;
            this.low_fuel.Visible = false;
            // 
            // global_warming_emissions_text
            // 
            this.global_warming_emissions_text.AutoSize = true;
            this.global_warming_emissions_text.Location = new System.Drawing.Point(157, 175);
            this.global_warming_emissions_text.Name = "global_warming_emissions_text";
            this.global_warming_emissions_text.Size = new System.Drawing.Size(0, 13);
            this.global_warming_emissions_text.TabIndex = 15;
            // 
            // thc_emissions_text
            // 
            this.thc_emissions_text.AutoSize = true;
            this.thc_emissions_text.Location = new System.Drawing.Point(127, 154);
            this.thc_emissions_text.Name = "thc_emissions_text";
            this.thc_emissions_text.Size = new System.Drawing.Size(0, 13);
            this.thc_emissions_text.TabIndex = 14;
            // 
            // nox_emissions_text
            // 
            this.nox_emissions_text.AutoSize = true;
            this.nox_emissions_text.Location = new System.Drawing.Point(127, 133);
            this.nox_emissions_text.Name = "nox_emissions_text";
            this.nox_emissions_text.Size = new System.Drawing.Size(0, 13);
            this.nox_emissions_text.TabIndex = 13;
            // 
            // co_emissions_text
            // 
            this.co_emissions_text.AutoSize = true;
            this.co_emissions_text.Location = new System.Drawing.Point(127, 112);
            this.co_emissions_text.Name = "co_emissions_text";
            this.co_emissions_text.Size = new System.Drawing.Size(0, 13);
            this.co_emissions_text.TabIndex = 11;
            // 
            // co2_emissions_text
            // 
            this.co2_emissions_text.AutoSize = true;
            this.co2_emissions_text.Location = new System.Drawing.Point(127, 91);
            this.co2_emissions_text.Name = "co2_emissions_text";
            this.co2_emissions_text.Size = new System.Drawing.Size(0, 13);
            this.co2_emissions_text.TabIndex = 12;
            // 
            // global_warming_emissions_value
            // 
            this.global_warming_emissions_value.AutoSize = true;
            this.global_warming_emissions_value.Location = new System.Drawing.Point(118, 175);
            this.global_warming_emissions_value.Name = "global_warming_emissions_value";
            this.global_warming_emissions_value.Size = new System.Drawing.Size(23, 13);
            this.global_warming_emissions_value.TabIndex = 10;
            this.global_warming_emissions_value.Text = "null";
            // 
            // thc_emissions_value
            // 
            this.thc_emissions_value.AutoSize = true;
            this.thc_emissions_value.Location = new System.Drawing.Point(78, 154);
            this.thc_emissions_value.Name = "thc_emissions_value";
            this.thc_emissions_value.Size = new System.Drawing.Size(23, 13);
            this.thc_emissions_value.TabIndex = 9;
            this.thc_emissions_value.Text = "null";
            // 
            // nox_emissions_value
            // 
            this.nox_emissions_value.AutoSize = true;
            this.nox_emissions_value.Location = new System.Drawing.Point(78, 133);
            this.nox_emissions_value.Name = "nox_emissions_value";
            this.nox_emissions_value.Size = new System.Drawing.Size(23, 13);
            this.nox_emissions_value.TabIndex = 8;
            this.nox_emissions_value.Text = "null";
            // 
            // global_warming_eq
            // 
            this.global_warming_eq.AutoSize = true;
            this.global_warming_eq.Location = new System.Drawing.Point(15, 175);
            this.global_warming_eq.Name = "global_warming_eq";
            this.global_warming_eq.Size = new System.Drawing.Size(97, 13);
            this.global_warming_eq.TabIndex = 7;
            this.global_warming_eq.Text = "Global warming EQ";
            // 
            // emissions_THC
            // 
            this.emissions_THC.AutoSize = true;
            this.emissions_THC.Location = new System.Drawing.Point(16, 154);
            this.emissions_THC.Name = "emissions_THC";
            this.emissions_THC.Size = new System.Drawing.Size(29, 13);
            this.emissions_THC.TabIndex = 6;
            this.emissions_THC.Text = "THC";
            // 
            // emissions_NOx
            // 
            this.emissions_NOx.AutoSize = true;
            this.emissions_NOx.Location = new System.Drawing.Point(15, 133);
            this.emissions_NOx.Name = "emissions_NOx";
            this.emissions_NOx.Size = new System.Drawing.Size(28, 13);
            this.emissions_NOx.TabIndex = 5;
            this.emissions_NOx.Text = "NOx";
            // 
            // co_emissions_value
            // 
            this.co_emissions_value.AutoSize = true;
            this.co_emissions_value.Location = new System.Drawing.Point(78, 112);
            this.co_emissions_value.Name = "co_emissions_value";
            this.co_emissions_value.Size = new System.Drawing.Size(23, 13);
            this.co_emissions_value.TabIndex = 4;
            this.co_emissions_value.Text = "null";
            // 
            // co2_emissions_value
            // 
            this.co2_emissions_value.AutoSize = true;
            this.co2_emissions_value.Location = new System.Drawing.Point(78, 91);
            this.co2_emissions_value.Name = "co2_emissions_value";
            this.co2_emissions_value.Size = new System.Drawing.Size(23, 13);
            this.co2_emissions_value.TabIndex = 4;
            this.co2_emissions_value.Text = "null";
            // 
            // type
            // 
            this.type.AutoSize = true;
            this.type.Location = new System.Drawing.Point(84, 20);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(21, 13);
            this.type.TabIndex = 3;
            this.type.Text = "%d";
            // 
            // vehicle_type
            // 
            this.vehicle_type.AutoSize = true;
            this.vehicle_type.Location = new System.Drawing.Point(10, 20);
            this.vehicle_type.Name = "vehicle_type";
            this.vehicle_type.Size = new System.Drawing.Size(68, 13);
            this.vehicle_type.TabIndex = 2;
            this.vehicle_type.Text = "Vehicle type:";
            // 
            // emissions_co
            // 
            this.emissions_co.AutoSize = true;
            this.emissions_co.Location = new System.Drawing.Point(15, 112);
            this.emissions_co.Name = "emissions_co";
            this.emissions_co.Size = new System.Drawing.Size(22, 13);
            this.emissions_co.TabIndex = 1;
            this.emissions_co.Text = "CO";
            // 
            // emissions_co2
            // 
            this.emissions_co2.AutoSize = true;
            this.emissions_co2.Location = new System.Drawing.Point(15, 91);
            this.emissions_co2.Name = "emissions_co2";
            this.emissions_co2.Size = new System.Drawing.Size(28, 13);
            this.emissions_co2.TabIndex = 1;
            this.emissions_co2.Text = "CO2";
            // 
            // type_label
            // 
            this.type_label.AutoSize = true;
            this.type_label.Location = new System.Drawing.Point(2, 61);
            this.type_label.Name = "type_label";
            this.type_label.Size = new System.Drawing.Size(45, 13);
            this.type_label.TabIndex = 1;
            this.type_label.Text = "%s level";
            // 
            // pb_battery
            // 
            this.pb_battery.Location = new System.Drawing.Point(82, 52);
            this.pb_battery.Name = "pb_battery";
            this.pb_battery.Size = new System.Drawing.Size(137, 23);
            this.pb_battery.Step = 1;
            this.pb_battery.TabIndex = 0;
            this.pb_battery.Value = 100;
            // 
            // emission_status
            // 
            this.emission_status.AutoSize = true;
            this.emission_status.Location = new System.Drawing.Point(14, 154);
            this.emission_status.Name = "emission_status";
            this.emission_status.Size = new System.Drawing.Size(83, 13);
            this.emission_status.TabIndex = 10;
            this.emission_status.Text = "emissions status";
            // 
            // lb_orderme
            // 
            this.lb_orderme.AutoSize = true;
            this.lb_orderme.Location = new System.Drawing.Point(808, 310);
            this.lb_orderme.Name = "lb_orderme";
            this.lb_orderme.Size = new System.Drawing.Size(35, 13);
            this.lb_orderme.TabIndex = 15;
            this.lb_orderme.Text = "label3";
            // 
            // orderme_timer
            // 
            this.orderme_timer.Tick += new System.EventHandler(this.orderme_timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 388);
            this.Controls.Add(this.lb_orderme);
            this.Controls.Add(this.emission_status);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.pb_start);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_commands);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.game_panel);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Move += new System.EventHandler(this.Form1_Move);
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
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
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
        private System.Windows.Forms.Label score_label;
        private System.Windows.Forms.Label lb_steps;
        private System.Windows.Forms.Label lift_label;
        private System.Windows.Forms.Label lift_state;
        private System.Windows.Forms.Panel warning_panel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox tb_commands;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem commandsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allToolStripMenuItem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem greekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.PictureBox pb_start;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog ofd_level;
        private System.Windows.Forms.Timer anim_timer;
        private System.Windows.Forms.Timer load_timer;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ToolStripMenuItem vehicleTypeToolStripMenuItem;
        private System.Windows.Forms.Label type;
        private System.Windows.Forms.Label vehicle_type;
        private System.Windows.Forms.Label emissions_co;
        private System.Windows.Forms.Label emissions_co2;
        private System.Windows.Forms.Label type_label;
        private System.Windows.Forms.ProgressBar pb_battery;
        private System.Windows.Forms.ToolStripMenuItem batteryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem petrolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lPGToolStripMenuItem;
        private System.Windows.Forms.Label emission_status;
        private System.Windows.Forms.Label co_emissions_value;
        private System.Windows.Forms.Label co2_emissions_value;
        private System.Windows.Forms.Label global_warming_emissions_value;
        private System.Windows.Forms.Label thc_emissions_value;
        private System.Windows.Forms.Label nox_emissions_value;
        private System.Windows.Forms.Label global_warming_eq;
        private System.Windows.Forms.Label emissions_THC;
        private System.Windows.Forms.Label emissions_NOx;
        private System.Windows.Forms.Label global_warming_emissions_text;
        private System.Windows.Forms.Label thc_emissions_text;
        private System.Windows.Forms.Label nox_emissions_text;
        private System.Windows.Forms.Label co_emissions_text;
        private System.Windows.Forms.Label co2_emissions_text;
        private System.Windows.Forms.Label low_fuel;
        private System.Windows.Forms.Label lb_orderme;
        private System.Windows.Forms.Timer orderme_timer;
    }
}

