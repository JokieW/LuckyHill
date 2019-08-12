namespace LuckyHill
{
    partial class form_settings
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
            this.grp_generalSettings = new System.Windows.Forms.GroupBox();
            this.cb_fillListNoFilter = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_higherFrameBound = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_lowerFrameBound = new System.Windows.Forms.TextBox();
            this.lbl_resultColumns = new System.Windows.Forms.Label();
            this.cbl_columns = new System.Windows.Forms.CheckedListBox();
            this.lbl_filters = new System.Windows.Forms.Label();
            this.cbl_filters = new System.Windows.Forms.CheckedListBox();
            this.lbl_riddleDifficulty = new System.Windows.Forms.Label();
            this.cmb_riddleSetting = new System.Windows.Forms.ComboBox();
            this.grp_generalSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // grp_generalSettings
            // 
            this.grp_generalSettings.Controls.Add(this.cb_fillListNoFilter);
            this.grp_generalSettings.Controls.Add(this.label2);
            this.grp_generalSettings.Controls.Add(this.txt_higherFrameBound);
            this.grp_generalSettings.Controls.Add(this.label1);
            this.grp_generalSettings.Controls.Add(this.txt_lowerFrameBound);
            this.grp_generalSettings.Controls.Add(this.lbl_resultColumns);
            this.grp_generalSettings.Controls.Add(this.cbl_columns);
            this.grp_generalSettings.Controls.Add(this.lbl_filters);
            this.grp_generalSettings.Controls.Add(this.cbl_filters);
            this.grp_generalSettings.Controls.Add(this.lbl_riddleDifficulty);
            this.grp_generalSettings.Controls.Add(this.cmb_riddleSetting);
            this.grp_generalSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.grp_generalSettings.Location = new System.Drawing.Point(0, 0);
            this.grp_generalSettings.Name = "grp_generalSettings";
            this.grp_generalSettings.Size = new System.Drawing.Size(388, 262);
            this.grp_generalSettings.TabIndex = 0;
            this.grp_generalSettings.TabStop = false;
            this.grp_generalSettings.Text = "General";
            // 
            // cb_fillListNoFilter
            // 
            this.cb_fillListNoFilter.AutoSize = true;
            this.cb_fillListNoFilter.Location = new System.Drawing.Point(9, 21);
            this.cb_fillListNoFilter.Name = "cb_fillListNoFilter";
            this.cb_fillListNoFilter.Size = new System.Drawing.Size(179, 17);
            this.cb_fillListNoFilter.TabIndex = 10;
            this.cb_fillListNoFilter.Text = "Fill list when no filters are applied";
            this.cb_fillListNoFilter.UseVisualStyleBackColor = true;
            this.cb_fillListNoFilter.CheckedChanged += new System.EventHandler(this.Cb_fillListNoFilter_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Higher frame bound";
            // 
            // txt_higherFrameBound
            // 
            this.txt_higherFrameBound.Location = new System.Drawing.Point(199, 57);
            this.txt_higherFrameBound.Name = "txt_higherFrameBound";
            this.txt_higherFrameBound.Size = new System.Drawing.Size(185, 20);
            this.txt_higherFrameBound.TabIndex = 8;
            this.txt_higherFrameBound.TextChanged += new System.EventHandler(this.Txt_higherFrameBound_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Lower frame bound";
            // 
            // txt_lowerFrameBound
            // 
            this.txt_lowerFrameBound.Location = new System.Drawing.Point(8, 57);
            this.txt_lowerFrameBound.Name = "txt_lowerFrameBound";
            this.txt_lowerFrameBound.Size = new System.Drawing.Size(185, 20);
            this.txt_lowerFrameBound.TabIndex = 6;
            this.txt_lowerFrameBound.TextChanged += new System.EventHandler(this.Txt_lowerFrameBound_TextChanged);
            // 
            // lbl_resultColumns
            // 
            this.lbl_resultColumns.AutoSize = true;
            this.lbl_resultColumns.Location = new System.Drawing.Point(5, 116);
            this.lbl_resultColumns.Name = "lbl_resultColumns";
            this.lbl_resultColumns.Size = new System.Drawing.Size(79, 13);
            this.lbl_resultColumns.TabIndex = 5;
            this.lbl_resultColumns.Text = "Result columns";
            // 
            // cbl_columns
            // 
            this.cbl_columns.CheckOnClick = true;
            this.cbl_columns.ColumnWidth = 75;
            this.cbl_columns.FormattingEnabled = true;
            this.cbl_columns.Location = new System.Drawing.Point(5, 132);
            this.cbl_columns.MultiColumn = true;
            this.cbl_columns.Name = "cbl_columns";
            this.cbl_columns.Size = new System.Drawing.Size(376, 124);
            this.cbl_columns.TabIndex = 4;
            this.cbl_columns.TabStop = false;
            this.cbl_columns.SelectedIndexChanged += new System.EventHandler(this.Cbl_columns_SelectedIndexChanged);
            // 
            // lbl_filters
            // 
            this.lbl_filters.AutoSize = true;
            this.lbl_filters.Location = new System.Drawing.Point(6, 116);
            this.lbl_filters.Name = "lbl_filters";
            this.lbl_filters.Size = new System.Drawing.Size(66, 13);
            this.lbl_filters.TabIndex = 3;
            this.lbl_filters.Text = "Filter options";
            this.lbl_filters.Visible = false;
            // 
            // cbl_filters
            // 
            this.cbl_filters.CheckOnClick = true;
            this.cbl_filters.ColumnWidth = 75;
            this.cbl_filters.FormattingEnabled = true;
            this.cbl_filters.Location = new System.Drawing.Point(5, 132);
            this.cbl_filters.MultiColumn = true;
            this.cbl_filters.Name = "cbl_filters";
            this.cbl_filters.Size = new System.Drawing.Size(185, 124);
            this.cbl_filters.TabIndex = 2;
            this.cbl_filters.TabStop = false;
            this.cbl_filters.Visible = false;
            this.cbl_filters.SelectedIndexChanged += new System.EventHandler(this.Cbl_filters_SelectedIndexChanged);
            // 
            // lbl_riddleDifficulty
            // 
            this.lbl_riddleDifficulty.AutoSize = true;
            this.lbl_riddleDifficulty.Location = new System.Drawing.Point(5, 89);
            this.lbl_riddleDifficulty.Name = "lbl_riddleDifficulty";
            this.lbl_riddleDifficulty.Size = new System.Drawing.Size(78, 13);
            this.lbl_riddleDifficulty.TabIndex = 0;
            this.lbl_riddleDifficulty.Text = "Riddle difficulty";
            // 
            // cmb_riddleSetting
            // 
            this.cmb_riddleSetting.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_riddleSetting.FormattingEnabled = true;
            this.cmb_riddleSetting.Location = new System.Drawing.Point(91, 86);
            this.cmb_riddleSetting.Name = "cmb_riddleSetting";
            this.cmb_riddleSetting.Size = new System.Drawing.Size(290, 21);
            this.cmb_riddleSetting.TabIndex = 1;
            this.cmb_riddleSetting.TabStop = false;
            this.cmb_riddleSetting.SelectedIndexChanged += new System.EventHandler(this.Cmb_riddleSetting_SelectedIndexChanged);
            // 
            // form_settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 265);
            this.Controls.Add(this.grp_generalSettings);
            this.Name = "form_settings";
            this.Text = "Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_settings_FormClosing);
            this.grp_generalSettings.ResumeLayout(false);
            this.grp_generalSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_generalSettings;
        private System.Windows.Forms.CheckedListBox cbl_columns;
        private System.Windows.Forms.Label lbl_filters;
        private System.Windows.Forms.CheckedListBox cbl_filters;
        private System.Windows.Forms.Label lbl_riddleDifficulty;
        private System.Windows.Forms.ComboBox cmb_riddleSetting;
        private System.Windows.Forms.Label lbl_resultColumns;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_higherFrameBound;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_lowerFrameBound;
        private System.Windows.Forms.CheckBox cb_fillListNoFilter;
    }
}