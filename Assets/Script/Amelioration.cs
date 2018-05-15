using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections; 
namespace Assets.Script
{
    class Amelioration
    {
        private int idAmelio;
        private ArrayList prerequisite;
        private string name;
        private Ressource cost;
        private int searchTime;

        public Amelioration(int id, ArrayList prerequisite, string name, Ressource cost, int searchTime)
        {
            this.idAmelio = id;
            this.prerequisite = prerequisite;
            this.name = name;
            this.cost = cost;
            this.searchTime = searchTime;
        }
    }
}
