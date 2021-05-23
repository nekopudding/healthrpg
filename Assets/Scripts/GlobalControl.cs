using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalControl : MonoBehaviour
{
    public static GlobalControl Instance;

    public int maxHealth = 100;
    public int currentHealth = 100;
    public int maxHealthXp = 10;
    public int currHealthXp = 0;


    public int maxMana = 100;
    public int currentMana = 100;
    public int maxManaXp = 10;
    public int currManaXp = 0;

    public HealthBar healthBar;
    public ManaBar manaBar;

    public ExpBar hpXpBar;
    public ExpBar mpXpBar;

    public Player player;

    public List<Enemy> enemies = new List<Enemy>();
    public Enemy currentEnemy;

    public static GlobalControl GetInstance()
    {
        return Instance;
    }

    void Awake()
    {
        if (Instance == null)
        {
            //Debug.Log("Creating instance");
            DontDestroyOnLoad(gameObject);
            Instance = this;
        }
        else if (Instance != this)
        {
            //Debug.Log("Instance already exists, destroying this");
            Destroy(gameObject);
        }
    }
}
