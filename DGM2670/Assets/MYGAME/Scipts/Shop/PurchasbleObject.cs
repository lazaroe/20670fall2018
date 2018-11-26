﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Purchase", menuName = "Store/Purchasable")]

public class PurchasbleObject : ScriptableObject {

	public Object Item;
	public int UsageCount = 3;
	public int Value;
	public bool Perpetual;
	public bool Instanciatable;

	public void CreateItem()
	{
		for (int i=0; i < UsageCount; i++)
		{
			if (Instanciatable && Item is GameObject)
			{
				Instantiate(Item);
			}
		}
	}

	public void Used()
	{
		UsageCount--;
	}
}
