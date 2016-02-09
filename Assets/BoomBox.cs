﻿using UnityEngine;
using System.Collections;

// change size of object depending on breathing


public class BoomBox : MonoBehaviour {

	public GameObject target;
	public LSLControllerBreathe modifier;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float value = modifier.Breathe;
		target.gameObject.transform.localScale = new Vector3 (value, value, value);
	
	}
}
