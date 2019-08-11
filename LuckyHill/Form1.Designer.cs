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
            this.lbl_carbon = new System.Windows.Forms.Label();
            this.txt_playerCarbon = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lv_results = new System.Windows.Forms.ListView();
            this.clh_rngIteration = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clh_clock = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clh_spin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clh_blood = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clh_carbon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clh_bugroom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clh_hangmen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clh_suitcase = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbl_version = new System.Windows.Forms.Label();
            this.lbl_author = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.bgw_listUpdate = new System.ComponentModel.BackgroundWorker();
            this.tmr_update = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_userClock
            // 
            this.txt_userClock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_userClock.Location = new System.Drawing.Point(5, 35);
            this.txt_userClock.MaxLength = 5;
            this.txt_userClock.Name = "txt_userClock";
            this.txt_userClock.Size = new System.Drawing.Size(51, 26);
            this.txt_userClock.TabIndex = 1;
            this.txt_userClock.TextChanged += new System.EventHandler(this.Txt_userClock_TextChanged);
            // 
            // txt_userSpin
            // 
            this.txt_userSpin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_userSpin.Location = new System.Drawing.Point(62, 35);
            this.txt_userSpin.MaxLength = 4;
            this.txt_userSpin.Name = "txt_userSpin";
            this.txt_userSpin.Size = new System.Drawing.Size(42, 26);
            this.txt_userSpin.TabIndex = 2;
            this.txt_userSpin.TextChanged += new System.EventHandler(this.Txt_userSpin_TextChanged);
            // 
            // txt_playerBlood
            // 
            this.txt_playerBlood.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_playerBlood.Location = new System.Drawing.Point(110, 35);
            this.txt_playerBlood.MaxLength = 4;
            this.txt_playerBlood.Name = "txt_playerBlood";
            this.txt_playerBlood.Size = new System.Drawing.Size(42, 26);
            this.txt_playerBlood.TabIndex = 3;
            this.txt_playerBlood.TextChanged += new System.EventHandler(this.Txt_playerBlood_TextChanged);
            // 
            // txt_userBug
            // 
            this.txt_userBug.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_userBug.Location = new System.Drawing.Point(206, 35);
            this.txt_userBug.MaxLength = 3;
            this.txt_userBug.Name = "txt_userBug";
            this.txt_userBug.Size = new System.Drawing.Size(33, 26);
            this.txt_userBug.TabIndex = 5;
            this.txt_userBug.TextChanged += new System.EventHandler(this.Txt_userBug_TextChanged);
            // 
            // txt_userHangmen
            // 
            this.txt_userHangmen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_userHangmen.Location = new System.Drawing.Point(245, 35);
            this.txt_userHangmen.MaxLength = 1;
            this.txt_userHangmen.Name = "txt_userHangmen";
            this.txt_userHangmen.Size = new System.Drawing.Size(50, 26);
            this.txt_userHangmen.TabIndex = 6;
            this.txt_userHangmen.TextChanged += new System.EventHandler(this.Txt_userHangmen_TextChanged);
            // 
            // txt_userSuitcase
            // 
            this.txt_userSuitcase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_userSuitcase.Location = new System.Drawing.Point(301, 35);
            this.txt_userSuitcase.MaxLength = 4;
            this.txt_userSuitcase.Name = "txt_userSuitcase";
            this.txt_userSuitcase.Size = new System.Drawing.Size(67, 26);
            this.txt_userSuitcase.TabIndex = 7;
            this.txt_userSuitcase.TextChanged += new System.EventHandler(this.Txt_userSuitcase_TextChanged);
            // 
            // lbl_playerClock
            // 
            this.lbl_playerClock.AutoSize = true;
            this.lbl_playerClock.Location = new System.Drawing.Point(6, 16);
            this.lbl_playerClock.Name = "lbl_playerClock";
            this.lbl_playerClock.Size = new System.Drawing.Size(34, 13);
            this.lbl_playerClock.TabIndex = 6;
            this.lbl_playerClock.Text = "Clock";
            // 
            // lbl_playerSpin
            // 
            this.lbl_playerSpin.AutoSize = true;
            this.lbl_playerSpin.Location = new System.Drawing.Point(59, 16);
            this.lbl_playerSpin.Name = "lbl_playerSpin";
            this.lbl_playerSpin.Size = new System.Drawing.Size(31, 13);
            this.lbl_playerSpin.TabIndex = 7;
            this.lbl_playerSpin.Text = "Lock";
            // 
            // lbl_playerBlood
            // 
            this.lbl_playerBlood.AutoSize = true;
            this.lbl_playerBlood.Location = new System.Drawing.Point(107, 16);
            this.lbl_playerBlood.Name = "lbl_playerBlood";
            this.lbl_playerBlood.Size = new System.Drawing.Size(34, 13);
            this.lbl_playerBlood.TabIndex = 8;
            this.lbl_playerBlood.Text = "Blood";
            // 
            // lbl_playerBug
            // 
            this.lbl_playerBug.AutoSize = true;
            this.lbl_playerBug.Location = new System.Drawing.Point(203, 16);
            this.lbl_playerBug.Name = "lbl_playerBug";
            this.lbl_playerBug.Size = new System.Drawing.Size(26, 13);
            this.lbl_playerBug.TabIndex = 9;
            this.lbl_playerBug.Text = "Bug";
            // 
            // lbl_playerHangmen
            // 
            this.lbl_playerHangmen.AutoSize = true;
            this.lbl_playerHangmen.Location = new System.Drawing.Point(242, 16);
            this.lbl_playerHangmen.Name = "lbl_playerHangmen";
            this.lbl_playerHangmen.Size = new System.Drawing.Size(44, 13);
            this.lbl_playerHangmen.TabIndex = 10;
            this.lbl_playerHangmen.Text = "Arsonist";
            // 
            // lbl_playerSuitcase
            // 
            this.lbl_playerSuitcase.AutoSize = true;
            this.lbl_playerSuitcase.Location = new System.Drawing.Point(301, 16);
            this.lbl_playerSuitcase.Name = "lbl_playerSuitcase";
            this.lbl_playerSuitcase.Size = new System.Drawing.Size(48, 13);
            this.lbl_playerSuitcase.TabIndex = 11;
            this.lbl_playerSuitcase.Text = "Suitcase";
            // 
            // groupBox1
            // 
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
            this.groupBox1.Location = new System.Drawing.Point(75, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(373, 70);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Player Results";
            // 
            // lbl_carbon
            // 
            this.lbl_carbon.AutoSize = true;
            this.lbl_carbon.Location = new System.Drawing.Point(155, 16);
            this.lbl_carbon.Name = "lbl_carbon";
            this.lbl_carbon.Size = new System.Drawing.Size(41, 13);
            this.lbl_carbon.TabIndex = 13;
            this.lbl_carbon.Text = "Carbon";
            // 
            // txt_playerCarbon
            // 
            this.txt_playerCarbon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_playerCarbon.Location = new System.Drawing.Point(158, 35);
            this.txt_playerCarbon.MaxLength = 4;
            this.txt_playerCarbon.Name = "txt_playerCarbon";
            this.txt_playerCarbon.Size = new System.Drawing.Size(42, 26);
            this.txt_playerCarbon.TabIndex = 4;
            this.txt_playerCarbon.TextChanged += new System.EventHandler(this.Txt_playerCarbon_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Possible combinations";
            // 
            // lv_results
            // 
            this.lv_results.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clh_rngIteration,
            this.clh_clock,
            this.clh_spin,
            this.clh_blood,
            this.clh_carbon,
            this.clh_bugroom,
            this.clh_hangmen,
            this.clh_suitcase});
            this.lv_results.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_results.FullRowSelect = true;
            this.lv_results.GridLines = true;
            this.lv_results.Location = new System.Drawing.Point(12, 101);
            this.lv_results.Name = "lv_results";
            this.lv_results.Size = new System.Drawing.Size(436, 207);
            this.lv_results.TabIndex = 8;
            this.lv_results.UseCompatibleStateImageBehavior = false;
            this.lv_results.View = System.Windows.Forms.View.Details;
            // 
            // clh_rngIteration
            // 
            this.clh_rngIteration.Text = "Frame";
            this.clh_rngIteration.Width = 68;
            // 
            // clh_clock
            // 
            this.clh_clock.Text = "Clock";
            this.clh_clock.Width = 52;
            // 
            // clh_spin
            // 
            this.clh_spin.Text = "Lock";
            this.clh_spin.Width = 48;
            // 
            // clh_blood
            // 
            this.clh_blood.Text = "Blood";
            this.clh_blood.Width = 48;
            // 
            // clh_carbon
            // 
            this.clh_carbon.Text = "Carbon";
            this.clh_carbon.Width = 48;
            // 
            // clh_bugroom
            // 
            this.clh_bugroom.Text = "Bug";
            this.clh_bugroom.Width = 39;
            // 
            // clh_hangmen
            // 
            this.clh_hangmen.Text = "Arsonist";
            this.clh_hangmen.Width = 55;
            // 
            // clh_suitcase
            // 
            this.clh_suitcase.Text = "Suitcase";
            this.clh_suitcase.Width = 72;
            // 
            // lbl_version
            // 
            this.lbl_version.AutoSize = true;
            this.lbl_version.Font = new System.Drawing.Font("Consolas", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_version.Location = new System.Drawing.Point(10, 311);
            this.lbl_version.Name = "lbl_version";
            this.lbl_version.Size = new System.Drawing.Size(115, 10);
            this.lbl_version.TabIndex = 2;
            this.lbl_version.Text = "Version: Chocomint 1.0";
            // 
            // lbl_author
            // 
            this.lbl_author.AutoSize = true;
            this.lbl_author.Font = new System.Drawing.Font("Consolas", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_author.Location = new System.Drawing.Point(378, 311);
            this.lbl_author.Name = "lbl_author";
            this.lbl_author.Size = new System.Drawing.Size(70, 10);
            this.lbl_author.TabIndex = 3;
            this.lbl_author.Text = "By Jokie#0001";
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
            // bgw_listUpdate
            // 
            this.bgw_listUpdate.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Bgw_listUpdate_DoWork);
            // 
            // tmr_update
            // 
            this.tmr_update.Interval = 1000;
            this.tmr_update.Tick += new System.EventHandler(this.Tmr_update_Tick);
            // 
            // form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 325);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_author);
            this.Controls.Add(this.lbl_version);
            this.Controls.Add(this.lv_results);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "form_main";
            this.Text = "Lucky Hill";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.ColumnHeader clh_rngIteration;
        private System.Windows.Forms.ColumnHeader clh_clock;
        private System.Windows.Forms.ColumnHeader clh_spin;
        private System.Windows.Forms.ColumnHeader clh_blood;
        private System.Windows.Forms.ColumnHeader clh_bugroom;
        private System.Windows.Forms.ColumnHeader clh_hangmen;
        private System.Windows.Forms.ColumnHeader clh_suitcase;
        private System.Windows.Forms.Label lbl_carbon;
        private System.Windows.Forms.TextBox txt_playerCarbon;
        private System.Windows.Forms.ColumnHeader clh_carbon;
        private System.Windows.Forms.Label lbl_version;
        private System.Windows.Forms.Label lbl_author;
        private System.Windows.Forms.Button button1;
        private System.ComponentModel.BackgroundWorker bgw_listUpdate;
        private System.Windows.Forms.Timer tmr_update;
    }
}

