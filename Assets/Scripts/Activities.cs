using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;
using System.Collections.Generic;

public class Activities : MonoBehaviour
{
    public static GlobalControl Instance;
    public Player player;
    public Button btn;

    public Text title;
    public Text expWorth;
    public Tuple<string, string> currAct;
    

    private Dictionary<Tuple<string, string>,int> act = new Dictionary<Tuple<string,string>, int>() {
        {new Tuple<string,string>("chat with a friend","mp"), 5 },
        {new Tuple<string,string>("take a small walk","hp"), 7 },
        {new Tuple<string,string>("write down things you are grateful for","mp"), 3 },
        {new Tuple<string,string>("drink water","hp"), 3 },
        {new Tuple<string,string>("dedicate family time","mp"), 10 },
        {new Tuple<string,string>("meditate for 10 min","mp"), 5 },
        {new Tuple<string,string>("talk to your neighbor","mp"), 7 },
        {new Tuple<string,string>("go for a run","hp"), 10 },
        {new Tuple<string,string>("workout","hp"), 10 },
        {new Tuple<string,string>("sleep on time","hp"), 7 },

    };
    List<Tuple<string, string>> keyList;
    List<int> valueList;




    // Start is called before the first frame update
    void Start()
    {
        Instance = GlobalControl.Instance;
        keyList = new List<Tuple<string, string>>(act.Keys);
        newActivity();
        btn.onClick.AddListener(newActivity);


    }

    // Update is called once per frame
    public void newActivity()
    {
        if (currAct != null) {
            player.GainExp(currAct.Item2, act[currAct]);
         }

        currAct = getRandomActivity();


        title.text = currAct.Item1;
        expWorth.text = act[currAct].ToString() + " " + currAct.Item2 + " exp";
    }

    public Tuple<string,string> getRandomActivity()
    {
        System.Random rand = new System.Random();
        return keyList[rand.Next(keyList.Count)];
    }
}
