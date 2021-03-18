using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeleteWin32___Project_2
{
    class Difficulty
    {
        private int startTime;
        private int reward;
        private int minSizeX;
        private int minSizeY;
        private int maxSizeX;
        private int maxSizeY;
        private int minPicSize;
        private int maxPicSize;
        public int StartTime { get => startTime; }
        public int Reward { get => reward; }
        public int MinSizeX { get => minSizeX; }
        public int MinSizeY { get => minSizeY; }
        public int MaxSizeX { get => maxSizeX; }
        public int MaxSizeY { get => maxSizeY; }
        public int MinPicSize { get => minPicSize; }
        public int MaxPicSize { get => maxPicSize; }

        public Difficulty(int startTime, int reward, int minSizeX, int minSizeY, int maxSizeX, int maxSizeY,int minPicSize, int maxPicSize)
        {
            this.startTime = startTime;
            this.reward = reward;
            this.minSizeX = minSizeX;
            this.minSizeY = minSizeY;
            this.maxSizeX = maxSizeX;
            this.maxSizeY = maxSizeY;
            this.minPicSize = minPicSize;
            this.maxPicSize = maxPicSize;
        }
        public Difficulty() { }


    }
}
