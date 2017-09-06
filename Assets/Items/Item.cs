using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu()]
[System.Serializable]
public class Item : ScriptableObject {

	public string itemName;
	public string description;
	public Sprite icon;

	public bool keyItem = false;
	public bool sellable = false;
	public bool droppable = true;

}