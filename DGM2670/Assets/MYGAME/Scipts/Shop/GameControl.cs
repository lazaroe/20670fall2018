using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour {

	public Text moneyText;
	public static float moneyAmount;
	int isRifleSold;
	public GameObject rifle;

	//second Item public
	int isRocketSold;
	public GameObject Rocket;
	void Start () 
	{
		moneyAmount = PlayerPrefs.GetInt ("MoneyAmount");
		isRifleSold = PlayerPrefs.GetInt ("IsRifleSold");

		if (isRifleSold == 1)
			rifle.SetActive (true);
		else
			rifle.SetActive (false);

		//part 2 rocket
		moneyAmount = PlayerPrefs.GetInt ("MoneyAmount");
		isRocketSold = PlayerPrefs.GetInt ("isRocketSold");

		if (isRocketSold == 1)
			Rocket.SetActive (true);
		else
			Rocket.SetActive (false);

	}
	
	void Update () {
		moneyText.text = "Money: " + moneyAmount.ToString() + "$";
	}

	public void gotoShop()
	{
		PlayerPrefs.SetInt ("MoneyAmount", (int)moneyAmount);
		SceneManager.LoadScene ("Shop");
	}


}