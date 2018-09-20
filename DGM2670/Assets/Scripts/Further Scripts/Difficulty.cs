using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Difficulty : MonoBehaviour {

	public int selectedLevel;
private int easy = 0, medium = 1, hard = 2;
void start()
		{
  		 switch(selectedLevel)
		{
		case 0:
		print("Easy");
		break;
		case 1:
		print("Medium");
		break;
		case 2:
		print("Hard");
		break;
		default:
		print("Not a choice");
		break;
		}
	}
}
