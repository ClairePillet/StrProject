using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Script
{
    class Tornado :EventGame
    {
        private int damage;
        private int radius;
        public Tornado(int idEvent, float chance, int damage, int radius)
            : base(idEvent, chance)
        {
            this.damage = damage;
            this.radius = radius; 
        }
    }
}
