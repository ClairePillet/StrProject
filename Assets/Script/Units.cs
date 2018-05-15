using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
namespace Assets.Script
{
    class Units:MonoBehaviour
    {
        private int idUnits;
        private int idplayer;
        private int idCase;
       
        private int pv;

        public Units(int id, int idPlayer,int idCase, string name, int pv )
        {
            this.idUnits = id;
            this.idplayer = idPlayer;
            this.idCase = idCase;
            this.name = name;
            this.pv = pv;
        }
    }
}
