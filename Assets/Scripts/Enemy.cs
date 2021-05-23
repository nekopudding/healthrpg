using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Enemy : MonoBehaviour
{
    static GlobalControl globalControl;
    
    public string name;
    public int lvl;
    public int hp;
    public int dmg;
    
    LatLon location;

    // Start is called before the first frame update
    void Start()
    {
        globalControl = GlobalControl.GetInstance();
    }

    public Enemy(string name, int lvl)
    {
        this.name = name;
        this.lvl = lvl;
        this.hp = lvl*10;
        this.dmg = (int) Math.Floor(lvl*0.5);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage(int damage)
    {
        hp -= damage;
    }
}
