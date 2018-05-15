
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Script
{
    class Building : MonoBehaviour
    {
        private int id;
        private int idCase;
        private int width;
        private int length;
        private int pv;
        private bool destructable;
       // private string name;
        private Ressource cost;
        private int idDistrict;
        private int idPlayer;

        public Building(int id, string name,  int idCase, int width,int length,int pv, int idDistrict, int idPlayer, Ressource cost, bool destructable)
        {
            this.id = id;
            this.name = name;
            this.idCase = idCase;
            this.width = width;
            this.length = length;
            this.destructable = destructable;
            this.pv = pv;
            this.cost = cost;
            this.idDistrict = idDistrict;
            this.idPlayer = idPlayer;

        }
        public int getId()
        {
            return id;
        }
        public string getName()
        {
            return name;
        }
        public int getIdCase()
        {
            return idCase;
        }
        public int getPv()
        {
            return pv;
        }
        public void setPv(int pv)
        {
            this.pv += pv;
            if (this.pv >= 0)
            {
                this.DestroyBuilding();
            }
        }
        public bool getDestructable()
        {
            return destructable;
        }
        public int getWidth()
        {
            return width;
        }
        public int getLength()
        {
            return length;
        }
        public int getIdDistrict()
        {
            return idDistrict;
        }
        public int getIdPlayer()
        {
            return idPlayer;
        }
        public void setIdPlayer(int idPlayer)
        {
            this.idPlayer = idPlayer;
        }
        public Ressource getCost()
        {
            return cost;
        }

        public void DestroyBuilding()
        {
            Object.Destroy(this.gameObject, 0f);
        }
    }
}
