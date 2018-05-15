using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Script
{
    class CaseMap
    {
        private int idCase;
        private Ressource resource;
        public CaseMap(int id, Ressource res)
        {
            this.idCase = id;
            this.resource = res;
        }
    }
}
