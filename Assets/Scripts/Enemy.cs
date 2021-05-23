using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class Enemy
{
    static GlobalControl globalControl;

    public string name;
    public int lvl;
    public int hp;
    public int dmg;
    public LatLon location;

    public Enemy(LatLon location, int lvl, int hp, int dmg)
    {
        this.location = location;
        this.lvl = lvl;
        this.hp = hp;
        this.dmg = dmg;
    }

    public Enemy(string name, int lvl)
    {
        this.name = name;
        this.lvl = lvl;
        this.hp = lvl*10;
        this.dmg = lvl;
    }

    public void TakeDamage(int damage)
    {
        hp -= damage;
    }
}
