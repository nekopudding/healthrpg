using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManaBar : MonoBehaviour
{

	public Slider slider;
	public Image fill;

	public Text currmanatext;
	public Text maxmanatext;

	public void SetMaxMana(int mana)
	{
		slider.maxValue = mana;
		slider.value = mana;
		maxmanatext.text = mana.ToString();
	}

	public void SetHealth(int mana)
	{
		slider.value = mana;
		currmanatext.text = mana.ToString();

	}

}