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
        public int StartTime { get { return startTime; } }
        private int reward;
        public int Reward { get { return reward; } }
        private int minSizeX;
        private int minSizeY;
        private int maxSizeX;
        private int maxSizeY;
        public int MinSizeX { get { return minSizeX; } }
        public int MinSizeY { get { return minSizeY; } }
        public int MaxSizeX { get { return maxSizeX; } }
        public int MaxSizeY { get { return maxSizeY; } }
        public Difficulty(int startTime, int reward, int minSizeX, int minSizeY, int maxSizeX, int maxSizeY)
        {
            this.startTime = startTime;
            this.reward = reward;
            this.minSizeX = minSizeX;
            this.minSizeY = minSizeY;
            this.maxSizeX = maxSizeX;
            this.maxSizeY = maxSizeY;
        }
        public Difficulty() { }


    }
}
