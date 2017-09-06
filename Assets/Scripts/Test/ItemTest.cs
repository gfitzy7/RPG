using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class ItemTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Debug.Log("STARTING");
		string[] assets = AssetDatabase.FindAssets("t:" + typeof(Item));
		foreach(string s in assets) {
			Debug.Log(s);
		}
		Debug.Log("FINISHING");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
