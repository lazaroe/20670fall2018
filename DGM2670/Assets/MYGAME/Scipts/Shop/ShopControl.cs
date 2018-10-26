﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;   
using UnityEngine.SceneManagement;

public class ShopControl : MonoBehaviour {

	int moneyAmount;
	int isRifleSold;

	public Text moneyAmountText;
	public Text riflePrice;

	public Button buyButton;

	void Start () {
		moneyAmount = PlayerPrefs.GetInt ("MoneyAmount");
	}
	
	void Update () {
		
		moneyAmountText.text = "Money: " + moneyAmount.ToString() + "$";

		isRifleSold = PlayerPrefs.GetInt ("IsRifleSold");

		if (moneyAmount >= 10 && isRifleSold == 0)
			buyButton.interactable = true;
		else
			buyButton.interactable = false;	
	}

	public void buyRifle()
	{
		moneyAmount -= 10;
		PlayerPrefs.SetInt ("IsRifleSold", 1);
		riflePrice.text = "Sold!";
		buyButton.gameObject.SetActive (false);
	}

	public void exitShop()
	{
		PlayerPrefs.SetInt ("MoneyAmount", moneyAmount);
		SceneManager.LoadScene ("Pgame");
	}

	public void resetPlayerPrefs()
	{
		moneyAmount = 0;
		buyButton.gameObject.SetActive (true);
		riflePrice.text = "Price: 10$";
		PlayerPrefs.DeleteAll ();
	}

}
