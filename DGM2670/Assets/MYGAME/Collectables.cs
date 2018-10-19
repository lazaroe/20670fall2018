using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collectables : MonoBehaviour {

	public int destroyTime = 4;
	public float speed;
   	 public Text countText;
   	 public Text winText;
	private int count;

	void Start ()
	{
	count = 0;
        SetCountText ();
        winText.text = "";
	}
	void Update () 
	{
		//This will make the object rotate as it falls down
        transform.Rotate (new Vector3 (15, 30, 45) * Time.deltaTime);
        Destroy (gameObject, destroyTime);
	}

	void OnTriggerEnter(Collider other) 
    {
	    //This will make the object dissapear
        if (other.gameObject.CompareTag ("Player"))
        {
              gameObject.SetActive (false);
	      count = count + 1;
            SetCountText ();
        }
    }
    void SetCountText ()
    {
	    //this will keep track of the object count
        countText.text = "Count: " + count.ToString ();
        if (count >= 12)
        {
            winText.text = "You Win!";
        }
    }
}
