using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
	public static GlobalControl Instance;

	public int maxHealth = 100;
	public int currentHealth;
	public int maxHealthXp = 10;
	public int currHealthXp = 0;


	public int maxMana = 100;
	public int currentMana;
	public int maxManaXp = 10;
	public int currManaXp = 0;

	public HealthBar healthBar;
	public ManaBar manaBar;

	public ExpBar hpXpBar;
	public ExpBar mpXpBar;

	// Start is called before the first frame update
	public void SavePlayer()
	{
		if (Instance != null) {
			Debug.Log("hdasfkj");
			GlobalControl.Instance.maxHealth = maxHealth;
			GlobalControl.Instance.currentHealth = currentHealth;
			GlobalControl.Instance.maxHealthXp = maxHealthXp;
			GlobalControl.Instance.currHealthXp = currHealthXp;

			GlobalControl.Instance.maxMana = maxMana;
			GlobalControl.Instance.currentMana = currentMana;
			GlobalControl.Instance.maxManaXp = maxManaXp;
			GlobalControl.Instance.currManaXp = currManaXp;

			GlobalControl.Instance.healthBar = healthBar;
			GlobalControl.Instance.manaBar = manaBar;
			GlobalControl.Instance.hpXpBar = hpXpBar;
			GlobalControl.Instance.mpXpBar = mpXpBar;
		}

	}

    public void Start()
    {
		if (Instance != null)
        {
			maxHealth = GlobalControl.Instance.maxHealth;
			currentHealth = GlobalControl.Instance.currentHealth;
			maxHealthXp = GlobalControl.Instance.maxHealthXp;
			currHealthXp = GlobalControl.Instance.currHealthXp;

			maxMana = GlobalControl.Instance.maxMana;
			currentMana = GlobalControl.Instance.currentMana;
			maxManaXp = GlobalControl.Instance.maxManaXp;
			currManaXp = GlobalControl.Instance.currManaXp;

			healthBar = GlobalControl.Instance.healthBar;
			manaBar = GlobalControl.Instance.manaBar;
			hpXpBar = GlobalControl.Instance.hpXpBar;
			mpXpBar = GlobalControl.Instance.mpXpBar;
		}
	}

    // Update is called once per frame
    void Update()
	{
		if (Input.GetKeyDown(KeyCode.Space))
		{
			TakeDamage(20);
		}
	}

	void TakeDamage(int damage)
	{
		currentHealth -= damage;

		healthBar.SetHealth(currentHealth);
	}

	void GainExp(string type, int amount)
    {
		if (type == "hp")
        {
			currHealthXp += amount;
			
			
			//level up
			if (currHealthXp >= maxHealthXp)
            {
				currHealthXp = 0;
				maxHealthXp += 2;
				maxHealth += 5;
				healthBar.SetMaxHealth(maxHealth);
				currentHealth = maxHealth;
			}
			hpXpBar.SetExp(currHealthXp);
		}
		else if (type == "mp")
		{
			currManaXp += amount;

			//level up
			if (currManaXp >= maxManaXp)
			{
				currManaXp = 0;
				maxManaXp += 2;
				maxMana += 5;
				manaBar.SetMaxMana(maxMana);
				currentMana = maxMana;
			}
			mpXpBar.SetExp(currManaXp);
		}
	}
}