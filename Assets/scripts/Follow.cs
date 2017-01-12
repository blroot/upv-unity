﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour {

	public GameObject target;
	private Vector3 offset;

	// Use this for initialization
	void Start () {
		
		this.offset = this.transform.position - target.transform.position;
	}
	
	// Update is called once per frame
	void Update () {

		this.transform.position = target.transform.position + this.offset;
	}
}
