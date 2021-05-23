using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    static GlobalControl globalControl;
    
    public string name;
    public int lvl = 5;
    public int hp = 50;
    public int dmg = 2;

    public Slider slider;

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
        this.dmg = lvl;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage(int damage)
    {
        hp -= damage;
        slider.value = hp;
    }
}
