using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{

	public Slider slider;
	public Image fill;
	public Text hptext;
	[SerializeField] private int maxHealth = 100;

	public void SetMaxHealth(int health)
	{
		slider.maxValue = health;
		slider.value = health;
		maxHealth = health;
	}

	public void SetHealth(int health)
	{
		slider.value = health;
		hptext.text = health.ToString() + " /" + maxHealth.ToString();
	}

}