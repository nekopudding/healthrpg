using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManaBar : MonoBehaviour
{

	public Slider slider;
	public Image fill;

	public Text mptext;
	[SerializeField] private int maxMana = 100;

	public void SetMaxMana(int mana)
	{
		slider.maxValue = mana;
		slider.value = mana;
		maxMana = mana;
	}

	public void SetMana(int mana)
	{
		slider.value = mana;
		mptext.text = mana.ToString() + " /" + maxMana.ToString();

	}

}