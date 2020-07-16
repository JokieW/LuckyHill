namespace LuckyHill
{
    partial class form_main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_main));
            this.txt_userClock = new System.Windows.Forms.TextBox();
            this.txt_userSpin = new System.Windows.Forms.TextBox();
            this.txt_playerBlood = new System.Windows.Forms.TextBox();
            this.txt_userBug = new System.Windows.Forms.TextBox();
            this.txt_userHangmen = new System.Windows.Forms.TextBox();
            this.txt_userSuitcase = new System.Windows.Forms.TextBox();
            this.lbl_playerClock = new System.Windows.Forms.Label();
            this.lbl_playerSpin = new System.Windows.Forms.Label();
            this.lbl_playerBlood = new System.Windows.Forms.Label();
            this.lbl_playerBug = new System.Windows.Forms.Label();
            this.lbl_playerHangmen = new System.Windows.Forms.Label();
            this.lbl_playerSuitcase = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_carbon = new System.Windows.Forms.Label();
            this.txt_playerCarbon = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lv_results = new System.Windows.Forms.ListView();
            this.bgw_listUpdate = new System.ComponentModel.BackgroundWorker();
            this.tmr_update = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_userClock
            // 
            this.txt_userClock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_userClock.Location = new System.Drawing.Point(75, 47);
            this.txt_userClock.MaxLength = 5;
            this.txt_userClock.Name = "txt_userClock";
            this.txt_userClock.Size = new System.Drawing.Size(51, 26);
            this.txt_userClock.TabIndex = 1;
            this.tooltip.SetToolTip(this.txt_userClock, "Time of the clock in Wood Side Apartments room 209.\r\nYou can search with the form" +
        "ats hh:mm, hhmm or hh.\r\nMidnight/Noon is 00.\r\n");
            this.txt_userClock.TextChanged += new System.EventHandler(this.Txt_userClock_TextChanged);
            // 
            // txt_userSpin
            // 
            this.txt_userSpin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_userSpin.Location = new System.Drawing.Point(132, 47);
            this.txt_userSpin.MaxLength = 4;
            this.txt_userSpin.Name = "txt_userSpin";
            this.txt_userSpin.Size = new System.Drawing.Size(42, 26);
            this.txt_userSpin.TabIndex = 2;
            this.tooltip.SetToolTip(this.txt_userSpin, "Initial cylinder lock positions for the Louis puzzle box.\r\nYou can search with th" +
        "e format xxxx.\r\n");
            this.txt_userSpin.TextChanged += new System.EventHandler(this.Txt_userSpin_TextChanged);
            // 
            // txt_playerBlood
            // 
            this.txt_playerBlood.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_playerBlood.Location = new System.Drawing.Point(180, 47);
            this.txt_playerBlood.MaxLength = 4;
            this.txt_playerBlood.Name = "txt_playerBlood";
            this.txt_playerBlood.Size = new System.Drawing.Size(42, 26);
            this.txt_playerBlood.TabIndex = 3;
            this.tooltip.SetToolTip(this.txt_playerBlood, "Code for the cylinder lock for the Louise puzzle box.\r\nYou can search with the fo" +
        "rmat xxxx.\r\n");
            this.txt_playerBlood.TextChanged += new System.EventHandler(this.Txt_playerBlood_TextChanged);
            // 
            // txt_userBug
            // 
            this.txt_userBug.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_userBug.Location = new System.Drawing.Point(276, 47);
            this.txt_userBug.MaxLength = 3;
            this.txt_userBug.Name = "txt_userBug";
            this.txt_userBug.Size = new System.Drawing.Size(33, 26);
            this.txt_userBug.TabIndex = 5;
            this.tooltip.SetToolTip(this.txt_userBug, "Code for the keypad in the bug room.\r\nYou can search with the format xxx.\r\n\r\n");
            this.txt_userBug.TextChanged += new System.EventHandler(this.Txt_userBug_TextChanged);
            // 
            // txt_userHangmen
            // 
            this.txt_userHangmen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_userHangmen.Location = new System.Drawing.Point(315, 47);
            this.txt_userHangmen.MaxLength = 1;
            this.txt_userHangmen.Name = "txt_userHangmen";
            this.txt_userHangmen.Size = new System.Drawing.Size(50, 26);
            this.txt_userHangmen.TabIndex = 6;
            this.tooltip.SetToolTip(this.txt_userHangmen, "Arsonist to pull down.\r\nYou can search with the numbers 1 to 6.\r\nThe numbers are " +
        "laid out like so:\r\n_____\r\n|door|__\r\n| 1  2  3 |\r\n| 6  5  4 |\r\n---------\r\n\r\n");
            this.txt_userHangmen.TextChanged += new System.EventHandler(this.Txt_userHangmen_TextChanged);
            // 
            // txt_userSuitcase
            // 
            this.txt_userSuitcase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_userSuitcase.Location = new System.Drawing.Point(371, 47);
            this.txt_userSuitcase.MaxLength = 4;
            this.txt_userSuitcase.Name = "txt_userSuitcase";
            this.txt_userSuitcase.Size = new System.Drawing.Size(67, 26);
            this.txt_userSuitcase.TabIndex = 7;
            this.tooltip.SetToolTip(this.txt_userSuitcase, resources.GetString("txt_userSuitcase.ToolTip"));
            this.txt_userSuitcase.TextChanged += new System.EventHandler(this.Txt_userSuitcase_TextChanged);
            // 
            // lbl_playerClock
            // 
            this.lbl_playerClock.AutoSize = true;
            this.lbl_playerClock.Location = new System.Drawing.Point(76, 28);
            this.lbl_playerClock.Name = "lbl_playerClock";
            this.lbl_playerClock.Size = new System.Drawing.Size(34, 13);
            this.lbl_playerClock.TabIndex = 6;
            this.lbl_playerClock.Text = "Clock";
            this.tooltip.SetToolTip(this.lbl_playerClock, "Time of the clock in Wood Side Apartments room 209.\r\nYou can search with the form" +
        "ats hh:mm, hhmm or hh.\r\nMidnight/Noon is 00.\r\n\r\n");
            // 
            // lbl_playerSpin
            // 
            this.lbl_playerSpin.AutoSize = true;
            this.lbl_playerSpin.Location = new System.Drawing.Point(129, 28);
            this.lbl_playerSpin.Name = "lbl_playerSpin";
            this.lbl_playerSpin.Size = new System.Drawing.Size(31, 13);
            this.lbl_playerSpin.TabIndex = 7;
            this.lbl_playerSpin.Text = "Lock";
            this.tooltip.SetToolTip(this.lbl_playerSpin, "Initial cylinder lock positions for the Louis puzzle box.\r\nYou can search with th" +
        "e format xxxx.\r\n\r\n");
            // 
            // lbl_playerBlood
            // 
            this.lbl_playerBlood.AutoSize = true;
            this.lbl_playerBlood.Location = new System.Drawing.Point(177, 28);
            this.lbl_playerBlood.Name = "lbl_playerBlood";
            this.lbl_playerBlood.Size = new System.Drawing.Size(34, 13);
            this.lbl_playerBlood.TabIndex = 8;
            this.lbl_playerBlood.Text = "Blood";
            this.tooltip.SetToolTip(this.lbl_playerBlood, "Code for the cylinder lock for the Louise puzzle box.\r\nYou can search with the fo" +
        "rmat xxxx.\r\n");
            // 
            // lbl_playerBug
            // 
            this.lbl_playerBug.AutoSize = true;
            this.lbl_playerBug.Location = new System.Drawing.Point(273, 28);
            this.lbl_playerBug.Name = "lbl_playerBug";
            this.lbl_playerBug.Size = new System.Drawing.Size(26, 13);
            this.lbl_playerBug.TabIndex = 9;
            this.lbl_playerBug.Text = "Bug";
            this.tooltip.SetToolTip(this.lbl_playerBug, "Code for the keypad in the bug room.\r\nYou can search with the format xxx.\r\n\r\n");
            // 
            // lbl_playerHangmen
            // 
            this.lbl_playerHangmen.AutoSize = true;
            this.lbl_playerHangmen.Location = new System.Drawing.Point(312, 28);
            this.lbl_playerHangmen.Name = "lbl_playerHangmen";
            this.lbl_playerHangmen.Size = new System.Drawing.Size(44, 13);
            this.lbl_playerHangmen.TabIndex = 10;
            this.lbl_playerHangmen.Text = "Arsonist";
            this.tooltip.SetToolTip(this.lbl_playerHangmen, "Arsonist to pull down.\r\nYou can search with the numbers 1 to 6.\r\nThe numbers are " +
        "laid out like so:\r\n_____\r\n|door|__\r\n| 1  2  3 |\r\n| 6  5  4 |\r\n---------\r\n");
            // 
            // lbl_playerSuitcase
            // 
            this.lbl_playerSuitcase.AutoSize = true;
            this.lbl_playerSuitcase.Location = new System.Drawing.Point(371, 28);
            this.lbl_playerSuitcase.Name = "lbl_playerSuitcase";
            this.lbl_playerSuitcase.Size = new System.Drawing.Size(48, 13);
            this.lbl_playerSuitcase.TabIndex = 11;
            this.lbl_playerSuitcase.Text = "Suitcase";
            this.tooltip.SetToolTip(this.lbl_playerSuitcase, resources.GetString("lbl_playerSuitcase.ToolTip"));
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.lbl_carbon);
            this.groupBox1.Controls.Add(this.lbl_playerClock);
            this.groupBox1.Controls.Add(this.txt_playerCarbon);
            this.groupBox1.Controls.Add(this.lbl_playerBug);
            this.groupBox1.Controls.Add(this.txt_userClock);
            this.groupBox1.Controls.Add(this.lbl_playerSuitcase);
            this.groupBox1.Controls.Add(this.lbl_playerBlood);
            this.groupBox1.Controls.Add(this.lbl_playerSpin);
            this.groupBox1.Controls.Add(this.txt_userSpin);
            this.groupBox1.Controls.Add(this.lbl_playerHangmen);
            this.groupBox1.Controls.Add(this.txt_userBug);
            this.groupBox1.Controls.Add(this.txt_playerBlood);
            this.groupBox1.Controls.Add(this.txt_userHangmen);
            this.groupBox1.Controls.Add(this.txt_userSuitcase);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.groupBox1.Size = new System.Drawing.Size(465, 89);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Player Results";
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::LuckyHill.Properties.Resources.icons8_reset_96;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(12, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 54);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // lbl_carbon
            // 
            this.lbl_carbon.AutoSize = true;
            this.lbl_carbon.Location = new System.Drawing.Point(225, 28);
            this.lbl_carbon.Name = "lbl_carbon";
            this.lbl_carbon.Size = new System.Drawing.Size(41, 13);
            this.lbl_carbon.TabIndex = 13;
            this.lbl_carbon.Text = "Carbon";
            this.tooltip.SetToolTip(this.lbl_carbon, "Code for the push-button lock on the Louise puzzle box.\r\nYou can search with the " +
        "format xxxx.");
            // 
            // txt_playerCarbon
            // 
            this.txt_playerCarbon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_playerCarbon.Location = new System.Drawing.Point(228, 47);
            this.txt_playerCarbon.MaxLength = 4;
            this.txt_playerCarbon.Name = "txt_playerCarbon";
            this.txt_playerCarbon.Size = new System.Drawing.Size(42, 26);
            this.txt_playerCarbon.TabIndex = 4;
            this.tooltip.SetToolTip(this.txt_playerCarbon, "Code for the push-button lock on the Louise puzzle box.\r\nYou can search with the " +
        "format xxxx.\r\n");
            this.txt_playerCarbon.TextChanged += new System.EventHandler(this.Txt_playerCarbon_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Location = new System.Drawing.Point(0, 113);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.label7.Size = new System.Drawing.Size(111, 19);
            this.label7.TabIndex = 1;
            this.label7.Text = "Possible combinations";
            // 
            // lv_results
            // 
            this.lv_results.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lv_results.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_results.FullRowSelect = true;
            this.lv_results.GridLines = true;
            this.lv_results.HideSelection = false;
            this.lv_results.Location = new System.Drawing.Point(0, 132);
            this.lv_results.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.lv_results.Name = "lv_results";
            this.lv_results.Size = new System.Drawing.Size(465, 245);
            this.lv_results.TabIndex = 8;
            this.lv_results.TabStop = false;
            this.lv_results.UseCompatibleStateImageBehavior = false;
            this.lv_results.View = System.Windows.Forms.View.Details;
            // 
            // bgw_listUpdate
            // 
            this.bgw_listUpdate.WorkerSupportsCancellation = true;
            this.bgw_listUpdate.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Bgw_listUpdate_DoWork);
            this.bgw_listUpdate.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.Bgw_listUpdate_RunWorkerCompleted);
            // 
            // tmr_update
            // 
            this.tmr_update.Interval = 1000;
            this.tmr_update.Tick += new System.EventHandler(this.Tmr_update_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.exportToolStripMenuItem,
            this.aboutToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(465, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.aboutToolStripMenuItem.Text = "Settings";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.exportToolStripMenuItem.Text = "Export";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem1.Text = "About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.AboutToolStripMenuItem1_Click);
            // 
            // form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 377);
            this.Controls.Add(this.lv_results);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(481, 216);
            this.Name = "form_main";
            this.Text = "Lucky Hill";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_main_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_userClock;
        private System.Windows.Forms.TextBox txt_userSpin;
        private System.Windows.Forms.TextBox txt_playerBlood;
        private System.Windows.Forms.TextBox txt_userBug;
        private System.Windows.Forms.TextBox txt_userHangmen;
        private System.Windows.Forms.TextBox txt_userSuitcase;
        private System.Windows.Forms.Label lbl_playerClock;
        private System.Windows.Forms.Label lbl_playerSpin;
        private System.Windows.Forms.Label lbl_playerBlood;
        private System.Windows.Forms.Label lbl_playerBug;
        private System.Windows.Forms.Label lbl_playerHangmen;
        private System.Windows.Forms.Label lbl_playerSuitcase;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListView lv_results;
        private System.Windows.Forms.Label lbl_carbon;
        private System.Windows.Forms.TextBox txt_playerCarbon;
        private System.Windows.Forms.Button button1;
        private System.ComponentModel.BackgroundWorker bgw_listUpdate;
        private System.Windows.Forms.Timer tmr_update;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolTip tooltip;
    }
}

