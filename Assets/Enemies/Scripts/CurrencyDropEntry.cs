using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class CurrencyDropEntry {

	public GameEnums.Currency currency;

	public int minAmt;
	public int maxAmt;

	[Range(0f, 1f)]
	public float dropChance = 1f;

}