using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyHill
{
    public class SanitizedPlayerInput
    {
        public int clockHours;
        public int clockMinutes;
        public byte[] spin;
        public byte[] blood;
        public byte[] carbon;
        public byte[] bug;
        public int hangman;
        public int suitcase;

        public bool HasClockSet { get => clockHours != -1 && clockMinutes != -1; }
        public bool HasSpinSet { get => spin[0] != 0 && spin[1] != 0 && spin[2] != 0 && spin[3] != 0; }
        public bool HasBloodSet { get => blood[0] != 0 && blood[1] != 0 && blood[2] != 0 && blood[3] != 0; }
        public bool HasCarbonSet { get => carbon[0] != 0 && carbon[1] != 0 && carbon[2] != 0 && carbon[3] != 0; }
        public bool HasBugSet { get => bug[0] != 0 && bug[1] != 0 && bug[2] != 0; }
        public bool HasHangmanSet { get => hangman != 0; }
        public bool HasSuitcaseSet { get => suitcase != -1; }
        public bool HasAnySet { get => HasClockSet || HasSpinSet || HasBloodSet || 
                HasCarbonSet || HasBugSet || HasHangmanSet || HasSuitcaseSet; }


        public SanitizedPlayerInput()
        {
            spin = new byte[4];
            blood = new byte[4];
            carbon = new byte[4];
            bug = new byte[3];
            Reset();
        }

        public void Reset()
        {
            clockHours = -1;
            clockMinutes = -1;

            spin[0] = 0;
            spin[1] = 0;
            spin[2] = 0;
            spin[3] = 0;

            blood[0] = 0;
            blood[1] = 0;
            blood[2] = 0;
            blood[3] = 0;

            carbon[0] = 0;
            carbon[1] = 0;
            carbon[2] = 0;
            carbon[3] = 0;

            bug[0] = 0;
            bug[1] = 0;
            bug[2] = 0;

            hangman = 0;
            suitcase = -1;
        }
    }
}
