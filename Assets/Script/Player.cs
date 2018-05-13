using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Script
{
    class Player
    {
        private int id;
        private string name;
        private bool isReal;
        private int popMax;
        private int popularity;
        private bool destructable;
        private bool isAlive;

        public Player(int id, string name,bool isReal, int popMax, int popularity, bool destructable)
        {
            this.id = id;
            this.name = name;
            this.isReal = isReal;
            this.popMax = popMax;
            this.popularity = popularity;
            this.destructable = destructable;
            this.isAlive = true;

        }
        public int getId()
        {
            return id;
        }
        public string getName()
        {
            return name;
        }
        public bool getIsReal()
        {
            return isReal;
        }
        public void setIsReal(bool isReal)
        {
            this.isReal = isReal;
        }
        public bool getGestructable()
        {
            return destructable;
        }
        public bool getIsAlive()
        {
            return isAlive;
        }
        public void setIsAlive(bool isReal)
        {
            this.isAlive = isReal;
        }
        public int getPopMac()
        {
            return popMax;
        }
        public void setPopMax(int popMax)
        {
            this.popMax = popMax;
        }
        public int getPopularity()
        {
            return popularity;
        }
        public void setPopularity(int popularity)
        {
            this.popularity = popularity;
        }
    }
}
