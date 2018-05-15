using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Script
{
    class Population
    {
        private int idProfile;
        private int idPlayer;
        private int hapiness;
        private int hope;
        private int security;
        private int number;
        public Population(int idPlayer, int hapiness ,int hope, int security, int number,int idProfile)
        {
            this.idPlayer = idPlayer;
            this.idProfile = idProfile;
            this.hapiness = hapiness;
            this.hope = hope;
            this.security = security;
            this.number = number;
        }
        public int getIdProfile()
        {
            return idProfile;
        }
        public int getIdPlayer()
        {
            return idPlayer;
        }
        public int getHope()
        {
            return hope;
        }
        public void setHope(int hope)
        {
            this.hope += hope;
        }
        public int getHapiness()
        {
            return hapiness;
        }
        public void setHapiness(int hapiness)
        {
            this.hapiness += hapiness;
        }
        public int getSecurity()
        {
            return security;
        }
        public void setSecurity(int security)
        {
            this.security += security;
        }
        public int getNumber()
        {
            return number;
        }
        public void setNumber(int number)
        {
            this.number += number;
        }
    }
}
