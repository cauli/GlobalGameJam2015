﻿using UnityEngine;
using System.Collections;

public class Item : MonoBehaviour {

	public Item[] possibleCombinations;
	public string nameItem;
	public string descripitonItem;

	// Use this for initialization
	void Start () {
		gameObject.rigidbody2D.AddTorque(Random.Range(-20,20));
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
