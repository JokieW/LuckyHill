using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LuckyHill
{
    public partial class form_main : Form
    {
        public form_main()
        {
            InitializeComponent();
            bgw_listUpdate.WorkerSupportsCancellation = true;
            tmr_update.Start();
            UpdateResultList();
        }

        private SanitizedPlayerInput _currentInputs = new SanitizedPlayerInput();
        private Queue<ListViewItem> _resultsStack = new Queue<ListViewItem>(1024);

        private void StopPreviousUpdate()
        {
            if (bgw_listUpdate.IsBusy)
            {
                bgw_listUpdate.CancelAsync();
            }
        }

        private void UpdateResultList()
        {
            if(bgw_listUpdate.IsBusy && !bgw_listUpdate.CancellationPending)
            {
                StopPreviousUpdate();
            }

            int antiInfinites = 0;
            while (bgw_listUpdate.IsBusy && antiInfinites < 1000000) { antiInfinites++; }
            lv_results.Items.Clear();
            _resultsStack.Clear();
            bgw_listUpdate.RunWorkerAsync();
        }
        private void Bgw_listUpdate_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;

            SH2Exe.SimulateRandomInitialisedFrom(_currentInputs, _resultsStack, () => worker.CancellationPending);
            if (worker.CancellationPending == true)
            {
                e.Cancel = true;
            }
        }

        private void Tmr_update_Tick(object sender, EventArgs e)
        {
            Timer t = sender as Timer;
            t.Stop();
            if (_resultsStack.Count > 0)
            {
                lock (_resultsStack)
                {
                    int tookTooLong = 0;
                    while (_resultsStack.Count > 0)
                    {
                        lv_results.Items.Add(_resultsStack.Dequeue());
                        tookTooLong++;
                        if (tookTooLong > 50) break;
                    }
                }
            }
            t.Start();
        }

        private void ValidateThreeDigits(string text, byte[] target)
        {
            int code1 = 0;
            int code2 = 0;
            int code3 = 0;

            if (!String.IsNullOrEmpty(text))
            {
                try
                {
                    if (text.Length != 3) return;
                    code1 = (int)char.GetNumericValue(text[0]) - 1;
                    code2 = (int)char.GetNumericValue(text[1]) - 1;
                    code3 = (int)char.GetNumericValue(text[2]) - 1;

                    if (code1 < 1 || code1 >= 9 ||
                        code2 < 1 || code2 >= 9 ||
                        code3 < 1 || code3 >= 9) return;
                }
                catch { return; }
            }

            StopPreviousUpdate();
            target[0] = (byte)code1;
            target[1] = (byte)code2;
            target[2] = (byte)code3;
            UpdateResultList();
        }

        private void ValidateFourDigits(string text, byte[] target)
        {
            int code1 = 0;
            int code2 = 0;
            int code3 = 0;
            int code4 = 0;

            if (!String.IsNullOrEmpty(text))
            {
                try
                {
                    if (text.Length != 4) return;
                    code1 = (int)char.GetNumericValue(text[0]);
                    code2 = (int)char.GetNumericValue(text[1]);
                    code3 = (int)char.GetNumericValue(text[2]);
                    code4 = (int)char.GetNumericValue(text[3]);

                    if (code1 < 1 || code1 >= 9 ||
                        code2 < 1 || code2 >= 9 ||
                        code3 < 1 || code3 >= 9 ||
                        code4 < 1 || code4 >= 9) return;
                }
                catch { return; }
            }

            StopPreviousUpdate();
            target[0] = (byte)code1;
            target[1] = (byte)code2;
            target[2] = (byte)code3;
            target[3] = (byte)code4;
            UpdateResultList();
        }

        private void Txt_userClock_TextChanged(object sender, EventArgs e)
        {
            string text = txt_userClock.Text;
            int hours = -1;
            int minutes = -1;

            if (!String.IsNullOrEmpty(text))
            {
                try
                {
                    if (text.Contains(':'))
                    {
                        string[] times = text.Split(':');
                        if (times.Length != 2) return;
                        hours = int.Parse(times[0]);
                        minutes = int.Parse(times[1]);
                    }
                    else
                    {
                        if (text.Length != 4) return;
                        hours = (int)char.GetNumericValue(text[0]) * 10;
                        hours += (int)char.GetNumericValue(text[1]);
                        minutes = (int)char.GetNumericValue(text[2]) * 10;
                        minutes += (int)char.GetNumericValue(text[3]);
                    }

                    if (hours < 0 || hours >= 24) return;
                    if (minutes < 0 || minutes >= 60) return;
                }
                catch { return; }
            }

            StopPreviousUpdate();
            _currentInputs.clockHours = hours;
            _currentInputs.clockMinutes = minutes;
            UpdateResultList();
        }

        private void Txt_userSpin_TextChanged(object sender, EventArgs e)
        {
            ValidateFourDigits(txt_userSpin.Text, _currentInputs.spin);
        }

        private void Txt_playerBlood_TextChanged(object sender, EventArgs e)
        {
            ValidateFourDigits(txt_playerBlood.Text, _currentInputs.blood);
        }

        private void Txt_playerCarbon_TextChanged(object sender, EventArgs e)
        {
            ValidateFourDigits(txt_playerCarbon.Text, _currentInputs.carbon);
        }

        private void Txt_userBug_TextChanged(object sender, EventArgs e)
        {
            ValidateThreeDigits(txt_userBug.Text, _currentInputs.bug);
        }

        private void Txt_userHangmen_TextChanged(object sender, EventArgs e)
        {
            string text = txt_userHangmen.Text;
            int hangmen = 0;
            if (!String.IsNullOrEmpty(text))
            {
                try
                {
                    if (text.Length != 1) return;
                    hangmen = (int)char.GetNumericValue(text[0]);
                    if (hangmen < 1 || hangmen > 6) return;
                }
                catch { return; }
            }

            StopPreviousUpdate();
            _currentInputs.hangman = hangmen;
            UpdateResultList();
        }

        private void Txt_userSuitcase_TextChanged(object sender, EventArgs e)
        {
            string text = txt_userSuitcase.Text;
            int suitcase = -1;
            if (!String.IsNullOrEmpty(text))
            {
                try
                {
                    if (text.Length != 4) return;
                    suitcase = SH2Exe.GetSuitcaseCodeIndex(text);
                    if (suitcase == -1) return;
                }
                catch { return; }
            }

            StopPreviousUpdate();
            _currentInputs.suitcase = suitcase;
            UpdateResultList();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            StopPreviousUpdate();
            txt_userClock.Text = "";
            txt_userSpin.Text = "";
            txt_playerBlood.Text = "";
            txt_playerCarbon.Text = "";
            txt_userBug.Text = "";
            txt_userHangmen.Text = "";
            txt_userSuitcase.Text = "";
            _currentInputs.Reset();
            UpdateResultList();
        }
    }
}
