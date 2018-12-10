using System.Collections;
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

	//Second Item public

	int isRocketSold;
	public Text rocketPrice;
	public Button buyRocketButton;

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
			//Second Item Update
		isRocketSold = PlayerPrefs.GetInt ("IsRocketSold");

		if (moneyAmount >= 20 && isRocketSold == 0)
			buyRocketButton.interactable = true;
		else
			buyRocketButton.interactable = false;	
	}

	public void buyRifle()
	{
		moneyAmount -= 10;
		PlayerPrefs.SetInt ("IsRifleSold", 1);
		riflePrice.text = "Sold!";
		buyButton.gameObject.SetActive (false);
	}

	public void buyRocket()
	{
		moneyAmount -= 20;
		PlayerPrefs.SetInt ("isRocketSold", 1);
		rocketPrice.text = "Sold!";
		buyRocketButton.gameObject.SetActive (false);
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

	///Second Item


}
