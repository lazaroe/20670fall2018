using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class MouseDownEvent : MonoBehaviour
{
	public void LoadScene()
	{
		SceneManager.LoadScene(2);
	}


}
