using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    static GlobalControl globalControl;
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
    // Start is called before the first frame update
    void Start()
    {
        globalControl = GlobalControl.GetInstance();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
