﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "store",menuName = "Store/StoreFront")]
public class Store : ScriptableObject {

	public Objects Available;
	public Objects Purchased;
	public void MakePurchase(Object obj)
	{
        for (int i = 0; i < Available.ObjectList.Count; i++)
		{
            Object availableObject = Available.ObjectList[i];
            if (availableObject == obj)
			{
				Purchased.ObjectList.Add(obj);
				Available.ObjectList.Remove(availableObject);
			}
		}
	}
}