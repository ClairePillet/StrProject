using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
namespace Assets.Script
{
    class EventGame:MonoBehaviour
    {
        private int idEvent;
        private float chance;

        public EventGame(int idEvent, float chance)
        {
            this.idEvent = idEvent;
            this.chance = chance;
        }

        public int getIdEvent()
        {
            return idEvent;
        }
        public float getChance()
        {
            return chance;
        }
    }
}
