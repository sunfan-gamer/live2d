﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateself : MonoBehaviour {

	public float speed = 90;
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(0,0,-speed*Time.deltaTime);
		
	}
}
