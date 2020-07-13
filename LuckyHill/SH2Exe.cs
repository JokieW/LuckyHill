using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace LuckyHill
{
    public static class SH2Exe
    {
        public static readonly IReadOnlyList<string> SuitcaseCodes = new List<string>
        {
            "open", "damn", "hell", "town", "dark", //  0  1  2  3  4
            "mama", "down", "love", "lock", "mist", //  5  6  7  8  9
            "luck", "lose", "dose", "over", "dust", // 10 11 12 13 14
            "time", "help", "kill", "null"          // 15 16 17 18
        };

        private static int _randomNumber = 1;

        public static int GetSuitcaseCodeIndex(string code)
        {
            for(int i = 0, len = SuitcaseCodes.Count; i < len; i++)
            {
                if (SuitcaseCodes[i] == code) return i;
            }
            return -1;
        }

        public static int RandomSauceShaker(ref int randomnumber)
        {
            unchecked { return randomnumber = (12345 - 1043968403 * randomnumber) & 0x7FFFFFFF; }
        }

        public static void ResetRandomSauce()
        {
            _randomNumber = 1;
        }


        private static byte[] _safeBuffer = new byte[4];
        private static byte[] _spinBuffer = new byte[4];
        private static byte[] _carbonBuffer = new byte[4];
        private static byte[] _bloodBuffer = new byte[4];
        private static byte[] _bugBuffer = new byte[4];
        private static int[] _hangmenNumbers = new int[] { 0, 1, 2, 3, 4, 5 };
        private static void ResetBuffers()
        {
            for(int i = 0; i < 4; i++)
            {
                _safeBuffer[i] = default;
                _spinBuffer[i] = default;
                _carbonBuffer[i] = default;
                _bloodBuffer[i] = default;
                _bugBuffer[i] = default;
            }
            for (int i = 0; i < 6; i++)
            {
                _hangmenNumbers[i] = i;
            }
        }


        public static void SimulateRandomInitialisedFrom(SanitizedPlayerInput inputs, UserSettings settings, Queue<ListViewItem> list, BackgroundWorker cancelPending, int maxIteration = 500)
        {
            ResetRandomSauce();
            ResetBuffers();
            int clockHourBuffer = 0;
            int clockMinuteBuffer = 0;
            int hangmanBuffer = 0;
            int faceBuffer = 0;
            int suitcaseBuffer = 0;

            int startFrame = 0;
            for(int i = 0; i < settings.lowerFrameBound + 424; i++, startFrame++)
            {
                if (cancelPending.CancellationPending) { return; }
                RandomSauceShaker(ref _randomNumber);
            }

            for (int iteration = 0, len = (settings.higherFrameBound + 424) - (settings.lowerFrameBound + 424); iteration <= len; iteration++)
            {
                if (cancelPending.CancellationPending) { return; }

                int iterationSeed = RandomSauceShaker(ref _randomNumber);

                //Unknown
                {
                    RandomSauceShaker(ref iterationSeed);
                    RandomSauceShaker(ref iterationSeed);
                    RandomSauceShaker(ref iterationSeed);
                }

                //Clock
                {
                    int clock = RandomSauceShaker(ref iterationSeed) % 0x294;
                    if ((ushort)clock > 0x208u)
                    {
                        clock += 0x3C;
                    }
                    clock = clock << 6;

                    clockHourBuffer = clock / 0xF00;
                    clockMinuteBuffer = (clock % 0xF00) / 0x40;
                }

                //Safe puzzle
                {
                    int i = 0;
                    do
                    {
                        int s = RandomSauceShaker(ref iterationSeed) % 20;
                        _safeBuffer[i] = (byte)s;
                        if (i > 0 && _safeBuffer[i - 1] == s)
                        {
                            _safeBuffer[i] = (byte)((s + 10) % 20);
                        }
                        ++i;
                    } while (i < 4);
                }

                RandomSauceShaker(ref iterationSeed);

                //Carbon, Blood, and Spin
                {
                    int i = 0;
                    do
                    {
                        _carbonBuffer[i] = (byte)(RandomSauceShaker(ref iterationSeed) % 9);
                        _bloodBuffer[i] = (byte)(RandomSauceShaker(ref iterationSeed) % 9);
                        _spinBuffer[i] = (byte)((RandomSauceShaker(ref iterationSeed) % 8 + _bloodBuffer[i++] + 1) % 9);
                    } while (i < 4);
                }

                //Bug room
                {
                    _bugBuffer[0] = (byte)(RandomSauceShaker(ref iterationSeed) % 9);
                    int bug1_15 = RandomSauceShaker(ref iterationSeed) % 8;
                    _bugBuffer[1] = (byte)bug1_15;
                    if(bug1_15 >= _bugBuffer[0])
                    {
                        _bugBuffer[1] = (byte)(bug1_15 + 1);
                    }
                    int bug2_16 = RandomSauceShaker(ref iterationSeed);
                    int bug2_18 = bug2_16;
                    int bug2_17 = bug2_16 % 7;
                    int bug2_19 = bug2_16 % 7;
                    _bugBuffer[2] = (byte)(bug2_18 % 7);
                    if(bug2_17 >= _bugBuffer[0])
                    {
                        _bugBuffer[2] = (byte)(++bug2_19);
                    }
                    if(bug2_17 >= _bugBuffer[1])
                    {
                        _bugBuffer[2] = (byte)(bug2_19 + 1);
                    }
                }

                //Hangman
                for (int i = 0; i < 6; i++)
                {
                    _hangmenNumbers[i] = i;
                }
                {
                    int i = 0;
                    int count = 6;
                    do
                    {
                        int h = i + RandomSauceShaker(ref iterationSeed) % count;
                        int h2 = _hangmenNumbers[i++];
                        --count;
                        int distribution = _hangmenNumbers[h] + 6 * hangmanBuffer;
                        if (_hangmenNumbers[h] == 5) hangmanBuffer = 7 - i;
                        _hangmenNumbers[h] = h2;
                    } while (count > 0);
                }

                //Faces
                {
                    faceBuffer = 0;
                    int leftright = RandomSauceShaker(ref iterationSeed) % 3 + 1;
                    if(settings.riddleDifficulty == UserSettings.RiddleDifficulty.Easy ||
                        settings.riddleDifficulty == UserSettings.RiddleDifficulty.Normal)
                    {
                        leftright = 1;
                    }
                    if((leftright & 1) != 0)
                    {
                        faceBuffer |= 0x1;
                    }

                    int updown = RandomSauceShaker(ref iterationSeed) % 3 + 1;
                    if (settings.riddleDifficulty == UserSettings.RiddleDifficulty.Easy ||
                        settings.riddleDifficulty == UserSettings.RiddleDifficulty.Normal)
                    {
                        updown = 2;
                    }
                    if ((updown & 1) != 0)
                    {
                        faceBuffer |= 0x2;
                    }
                    if ((updown & 2) != 0)
                    {
                        faceBuffer |= 0x4;
                    }
                }

                //Suitcase
                {
                    suitcaseBuffer = RandomSauceShaker(ref iterationSeed) % 19;
                }

                //Unknown
                {
                    RandomSauceShaker(ref iterationSeed);
                    RandomSauceShaker(ref iterationSeed);
                }

                //Adjustements
                {
                    for (int i = 0; i < 4; i++)
                    {
                        _safeBuffer[i]++;
                        _spinBuffer[i]++;
                        _carbonBuffer[i]++;
                        _bloodBuffer[i]++;
                        _bugBuffer[i]++;
                    }
                }

                if (cancelPending.CancellationPending) { return; }

                //Check if good to show
                bool addResults = false;
                if(!inputs.HasAnySet)
                {
                    if(settings.fillList) addResults = true;
                }
                else
                {
                    addResults = true;
                    if (inputs.HasClockSet && 
                        (inputs.clockHours != clockHourBuffer || (inputs.clockMinutes != -1 && inputs.clockMinutes != clockMinuteBuffer)))
                        addResults = false;
                    if (addResults && inputs.HasSpinSet &&
                        (inputs.spin[0] != _spinBuffer[0] || inputs.spin[1] != _spinBuffer[1] || inputs.spin[2] != _spinBuffer[2] || inputs.spin[3] != _spinBuffer[3]))
                        addResults = false;
                    if (addResults && inputs.HasBloodSet &&
                        (inputs.blood[0] != _bloodBuffer[0] || inputs.blood[1] != _bloodBuffer[1] || inputs.blood[2] != _bloodBuffer[2] || inputs.blood[3] != _bloodBuffer[3]))
                        addResults = false;
                    if (addResults && inputs.HasCarbonSet &&
                        (inputs.carbon[0] != _carbonBuffer[0]  || inputs.carbon[1] != _carbonBuffer[1] || inputs.carbon[2] != _carbonBuffer[2] || inputs.carbon[3] != _carbonBuffer[3]))
                        addResults = false;
                    if (addResults && inputs.HasBugSet &&
                        (inputs.bug[0] != _bugBuffer[0] || inputs.bug[1] != _bugBuffer[1] || inputs.bug[2] != _bugBuffer[2]))
                        addResults = false;
                    if (addResults && inputs.HasHangmanSet &&
                        (inputs.hangman != hangmanBuffer))
                        addResults = false;
                    if (addResults && inputs.HasSuitcaseSet &&
                        (inputs.suitcase != suitcaseBuffer))
                        addResults = false;
                }

                if (cancelPending.CancellationPending) { return; }

                if (addResults)
                {
                    lock (list)
                    {
                        list.Enqueue(
                            new ListViewItem(new string[]
                            {
                            (iteration + startFrame - 424).ToString(),
                            clockHourBuffer.ToString("00") + ":" + clockMinuteBuffer.ToString("00"),
                            string.Concat(_safeBuffer[0].ToString(), " ", _safeBuffer[1].ToString(), " ", _safeBuffer[2].ToString(), " ", _safeBuffer[3].ToString()),
                            string.Concat(_spinBuffer[0].ToString(), _spinBuffer[1].ToString(), _spinBuffer[2].ToString(), _spinBuffer[3].ToString()),
                            string.Concat(_bloodBuffer[0].ToString(), _bloodBuffer[1].ToString(), _bloodBuffer[2].ToString(), _bloodBuffer[3].ToString()),
                            string.Concat(_carbonBuffer[0].ToString(), _carbonBuffer[1].ToString(), _carbonBuffer[2].ToString(), _carbonBuffer[3].ToString()),
                            string.Concat(_bugBuffer[0].ToString(), _bugBuffer[1].ToString(), _bugBuffer[2].ToString()),
                            string.Concat((faceBuffer & 0x1) != 0 ? "S " : "", (faceBuffer & 0x6) == 6 ? "U" : "", (faceBuffer & 0x6) == 4 ? "D D" : "", (faceBuffer & 0x6) == 2 ? "D" : ""),
                            hangmanBuffer.ToString(),
                            SuitcaseCodes[suitcaseBuffer]
                            }));
                    }
                }

                if (cancelPending.CancellationPending) { return; }
            }
        }
    }
}
