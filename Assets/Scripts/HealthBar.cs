using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{

	public Slider slider;
	public Image fill;
	public Text currhptext;
	public Text maxhptext;

	public void SetMaxHealth(int health)
	{
		slider.maxValue = health;
		slider.value = health;
		maxhptext.text = health.ToString();
	}

	public void SetHealth(int health)
	{
		slider.value = health;
		currhptext.text = health.ToString();
	}

}