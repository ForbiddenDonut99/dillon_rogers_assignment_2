﻿using UnityEngine;
using System.Collections;

public class Restart : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Screen.showCursor = false;
		Screen.lockCursor = true;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Tab)) {
			Application.LoadLevel (0);
	}
}
}
	