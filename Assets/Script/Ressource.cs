using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ressource {

    private int id;
    private int idPlayer;
    private int water;
    private int scrap;
    private int food;
    private int energy;


    public Ressource(int idPlayer)
    {
        this.idPlayer = idPlayer;
    }
    public int getId()
    {
        return id;
    }
    public int getIdPlayer()
    {
        return idPlayer;
    }

    public Dictionary<string,int> getRessource(){
        Dictionary<string,int> dic= new Dictionary<string, int>();
        dic.Add("water", water);
        dic.Add("scrap", scrap);
        dic.Add("food", food);
        dic.Add("energy", energy);
        return dic;
    }
    public void setRessource(Dictionary<string, int> dic)
    {   
        int  water;
        int scrap;
        int food;
        int energy;
        dic.TryGetValue("water", out water);
        dic.TryGetValue("scrap", out scrap);
        dic.TryGetValue("food", out food);
        dic.TryGetValue("energy", out energy);
        this.water += water;
        this.scrap += scrap;
        this.food += food;
        this.energy += energy;
    }

}
