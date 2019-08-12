using System;
using System.Linq;
using System.Windows.Forms;
using RNGColumns = LuckyHill.UserSettings.RNGColumns;
using RiddleDifficulty = LuckyHill.UserSettings.RiddleDifficulty;

namespace LuckyHill
{
    public partial class form_settings : Form
    {
        UserSettings _settings;

        public form_settings()
        {
            InitializeComponent();

            cmb_riddleSetting.Items.Clear();
            string[] riddleDifficulties = Enum.GetNames(typeof(RiddleDifficulty));
            for(int i = 0, len = riddleDifficulties.Length; i < len; i++)
            {
                cmb_riddleSetting.Items.Add(riddleDifficulties[i]);
            }

            string[] RNGNames = Enum.GetNames(typeof(RNGColumns));
            cbl_filters.Items.Clear();
            cbl_columns.Items.Clear();
            for (int i = 0, len = RNGNames.Length; i < len; i++)
            {
                cbl_filters.Items.Add(RNGNames[i]);
                cbl_columns.Items.Add(RNGNames[i]);
            }
        }

        bool tempFillList;
        RNGColumns tempFilters;
        RNGColumns tempColumns;
        RiddleDifficulty tempRiddleDifficulty;
        int tempFrameLower;
        int tempFrameHigher;

        public void SetUserSettings(UserSettings settings)
        {
            _settings = settings;

            tempFillList = _settings.fillList;
            tempFilters = _settings.filtersToShow;
            tempColumns = _settings.columnsToShow;
            tempRiddleDifficulty = _settings.riddleDifficulty;
            tempFrameLower = _settings.lowerFrameBound;
            tempFrameHigher = _settings.higherFrameBound;

            cb_fillListNoFilter.Checked = _settings.fillList;
            txt_lowerFrameBound.Text = _settings.lowerFrameBound.ToString();
            txt_higherFrameBound.Text = _settings.higherFrameBound.ToString();
            cmb_riddleSetting.SelectedIndex = (int)_settings.riddleDifficulty;

            for (int i = 0, len = cbl_filters.Items.Count; i < len; i++)
            {
                RNGColumns f = (RNGColumns)Enum.Parse(typeof(RNGColumns), cbl_filters.Items[i].ToString());
                RNGColumns c = (RNGColumns)Enum.Parse(typeof(RNGColumns), cbl_columns.Items[i].ToString());

                cbl_filters.SetItemChecked(i, (_settings.filtersToShow & f) != 0);
                cbl_columns.SetItemChecked(i, (_settings.columnsToShow & c) != 0);
            }
        }

        private void Form_settings_FormClosing(object sender, FormClosingEventArgs e)
        {
            _settings.fillList = tempFillList;
            _settings.filtersToShow = tempFilters;
            _settings.columnsToShow = tempColumns;
            _settings.riddleDifficulty = tempRiddleDifficulty;
            _settings.lowerFrameBound = tempFrameLower;
            _settings.higherFrameBound = tempFrameHigher;
        }

        private void Cb_fillListNoFilter_CheckedChanged(object sender, EventArgs e)
        {
            tempFillList = ((CheckBox)sender).Checked;
        }

        private void Txt_lowerFrameBound_TextChanged(object sender, EventArgs e)
        {
            TextBox t = sender as TextBox;
            string text = t.Text;
            int toSet = tempFrameLower;
            bool doTextChange = false;
            if(!string.IsNullOrEmpty(text))
            {
                if (Int32.TryParse(text, out int attempt))
                {
                    toSet = attempt;
                    if (toSet > tempFrameHigher)
                    {
                        toSet = tempFrameHigher - 1;
                        doTextChange = true;
                    }
                    if (toSet < -424)
                    {
                        toSet = -424;
                        doTextChange = true;
                    }
                    tempFrameLower = toSet;
                }
            }
            else
            {
                toSet = -100;
                doTextChange = true;
            }

            if(doTextChange)
            {
                t.Text = toSet.ToString();
            }
        }

        private void Txt_higherFrameBound_TextChanged(object sender, EventArgs e)
        {
            TextBox t = sender as TextBox;
            string text = t.Text;
            int toSet = tempFrameHigher;
            bool doTextChange = false;
            if (!string.IsNullOrEmpty(text))
            {
                if (Int32.TryParse(text, out int attempt))
                {
                    toSet = attempt;
                    if (toSet < tempFrameLower)
                    {
                        toSet = tempFrameLower + 1;
                        doTextChange = true;
                    }
                    if (toSet > 100000)
                    {
                        toSet = 100000;
                        doTextChange = true;
                    }
                    tempFrameHigher = toSet;
                }
            }
            else
            {
                toSet = 100;
                doTextChange = true;
            }

            if (doTextChange)
            {
                t.Text = toSet.ToString();
            }
        }

        private void Cmb_riddleSetting_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            tempRiddleDifficulty = (RiddleDifficulty)cb.SelectedIndex;
        }

        private void Cbl_filters_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckedListBox c = sender as CheckedListBox;
            tempFilters = 0;
            for (int i = 0, len = c.Items.Count; i < len; i++)
            {
                object o = c.Items[i];
                if (c.GetItemCheckState(i) == CheckState.Checked)
                    tempFilters |= (RNGColumns)Enum.Parse(typeof(RNGColumns), o.ToString());
            }
        }

        private void Cbl_columns_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckedListBox c = sender as CheckedListBox;
            tempColumns = 0;
            for (int i = 0, len = c.Items.Count; i < len; i++)
            {
                object o = c.Items[i];
                if (c.GetItemCheckState(i) == CheckState.Checked)
                    tempColumns |= (RNGColumns)Enum.Parse(typeof(RNGColumns), o.ToString());
            }
        }
    }
}
