using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyHill
{
    public class UserSettings
    {
        [Flags]
        public enum RNGColumns
        {
            Frame = 0x01,
            Clock = 0x02,
            Safe = 0x04,
            Lock = 0x08,

            Blood = 0x10,
            Carbon = 0x20,
            Bug = 0x40,
            Faces = 0x80,

            Arsonist = 0x100,
            Suitcase = 0x200
        }

        public enum RiddleDifficulty
        {
            Easy = 0,
            Normal =  1,
            Hard = 2,
            Extra = 3 
        }

        public bool fillList = true;

        public RNGColumns columnsToShow = RNGColumns.Frame | RNGColumns.Clock | RNGColumns.Safe | RNGColumns.Lock |
            RNGColumns.Blood | RNGColumns.Carbon | RNGColumns.Bug | RNGColumns.Faces | RNGColumns.Arsonist |  RNGColumns.Suitcase;

        public RNGColumns filtersToShow = RNGColumns.Clock | RNGColumns.Lock |
            RNGColumns.Blood | RNGColumns.Carbon | RNGColumns.Bug | RNGColumns.Arsonist | RNGColumns.Suitcase;

        public RiddleDifficulty riddleDifficulty = RiddleDifficulty.Hard;

        public int lowerFrameBound = -100;
        public int higherFrameBound = 100;

        public void LoadFromDisk(form_main main)
        {
            filtersToShow = (RNGColumns)Settings1.Default.FilterColumns;
            columnsToShow = (RNGColumns)Settings1.Default.ResultColumns;
            riddleDifficulty = (RiddleDifficulty)Settings1.Default.RiddleDifficulty;
            lowerFrameBound = Settings1.Default.FrameLowerBound;
            higherFrameBound = Settings1.Default.FrameHigherBound;
            main.Width = Settings1.Default.MainFormWidth;
            main.Height = Settings1.Default.MainFormHeight;
        }

        public void SaveToDisk(form_main main)
        {
            Settings1.Default.FilterColumns = (int)filtersToShow;
            Settings1.Default.ResultColumns = (int)columnsToShow;
            Settings1.Default.RiddleDifficulty = (int)riddleDifficulty;
            Settings1.Default.FrameLowerBound = lowerFrameBound;
            Settings1.Default.FrameHigherBound = higherFrameBound;
            Settings1.Default.MainFormWidth = main.Width;
            Settings1.Default.MainFormHeight = main.Height;
            Settings1.Default.Save();
        }
    }
}
