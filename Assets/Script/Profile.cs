using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Script
{
    class Profile
    {
        private int IdProfile;
        private Building[] loveBuilding;
        private EventGame loveEvent;

        public Profile(int id, Building[] building , EventGame loveEvent)
        {
            this.IdProfile = id;
            this.loveBuilding = building;
            this.loveEvent = loveEvent;
        }

        public int getIdProfile()
        {
            return IdProfile;
        }
        public Building[] getLoveBuilding()
        {
            return loveBuilding;
        }
        public EventGame getLoveEvent()
        {
            return loveEvent;
        }
    }
}
