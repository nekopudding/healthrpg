using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    static GlobalControl globalControl;
    public int lvl;
    public int hp;
    public int dmg;
    LatLon location;

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
