using UnityEngine;

public class IfStatements : MonoBehaviour
{
	  void OnCollisionEnter(Collision otherObj)
	   {
		if (otherObj.gameObject.tag == "Trap")
		{
        Destroy(gameObject);
		}
	}
}