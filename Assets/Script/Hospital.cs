using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Script
{
     class Hospital : Building
    {
        public Hospital(int id, string name, int idCase, int width, int length, int pv, int idDistrict, int idPlayer, Ressource cost, bool destructable) 
            :base( id,  name,  idCase,  width,  length,  pv,  idDistrict,  idPlayer,  cost,  destructable)
        {
            
        }
        public void doVacination()
        {

        }
        public void doResearch()
        {

        }
    }
}
