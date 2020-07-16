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
        bool tempIgnoreBounds;
        RNGColumns tempFilters;
        RNGColumns tempColumns;
        RiddleDifficulty tempRiddleDifficulty;
        bool tempGotLeaveEnding;
        bool tempGotMariaEnding;
        bool tempGotWaterEnding;
        int tempFrameLower;
        int tempFrameHigher;

        public void SetUserSettings(UserSettings settings)
        {
            _settings = settings;

            tempFillList = _settings.fillList;
            tempIgnoreBounds = _settings.ignoreBounds;
            tempFilters = _settings.filtersToShow;
            tempColumns = _settings.columnsToShow;
            tempRiddleDifficulty = _settings.riddleDifficulty;
            tempGotLeaveEnding = _settings.gotLeaveEnding;
            tempGotMariaEnding = _settings.gotMariaEnding;
            tempGotWaterEnding = _settings.gotWaterEnding;
            tempFrameLower = _settings.lowerFrameBound;
            tempFrameHigher = _settings.higherFrameBound;

            cb_fillListNoFilter.Checked = _settings.fillList;
            cb_ignoreBoundsWhenSearching.Checked = _settings.ignoreBounds;
            txt_lowerFrameBound.Text = _settings.lowerFrameBound.ToString();
            txt_higherFrameBound.Text = _settings.higherFrameBound.ToString();
            cmb_riddleSetting.SelectedIndex = (int)_settings.riddleDifficulty;
            cb_gotLeaveEnding.Checked = _settings.gotLeaveEnding;
            cb_gotMariaEnding.Checked = _settings.gotMariaEnding;
            cb_gotWaterEnding.Checked = _settings.gotWaterEnding;

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
            _settings.ignoreBounds = tempIgnoreBounds;
            _settings.filtersToShow = tempFilters;
            _settings.columnsToShow = tempColumns;
            _settings.riddleDifficulty = tempRiddleDifficulty;
            _settings.gotLeaveEnding = tempGotLeaveEnding;
            _settings.gotMariaEnding = tempGotMariaEnding;
            _settings.gotWaterEnding = tempGotWaterEnding;
            _settings.lowerFrameBound = tempFrameLower;
            _settings.higherFrameBound = tempFrameHigher;
        }

        private void Cb_fillListNoFilter_CheckedChanged(object sender, EventArgs e)
        {
            tempFillList = ((CheckBox)sender).Checked;
        }

        private void cb_ignoreBoundsWhenSearching_CheckedChanged(object sender, EventArgs e)
        {
            tempIgnoreBounds = ((CheckBox)sender).Checked;
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
                    if (toSet < -427)
                    {
                        toSet = -427;
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

        private void cb_gotLeaveEnding_CheckedChanged(object sender, EventArgs e)
        {
            tempGotLeaveEnding = ((CheckBox)sender).Checked;
        }

        private void cb_gotMariaEnding_CheckedChanged(object sender, EventArgs e)
        {
            tempGotMariaEnding = ((CheckBox)sender).Checked;
        }

        private void cb_gotWaterEnding_CheckedChanged(object sender, EventArgs e)
        {
            tempGotWaterEnding = ((CheckBox)sender).Checked;
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
