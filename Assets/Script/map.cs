using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Script
{
    class Map
    {
        private int id;
        private int length;
        private int width;
        private CaseMap caseMap;
        public Map(int id, int length, int width, CaseMap caseMap)
        {
            this.id = id;
            this.length = length;
            this.width = width;
            this.caseMap = caseMap;
        }
    }
}
