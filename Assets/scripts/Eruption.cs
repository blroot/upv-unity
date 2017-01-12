using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eruption : MonoBehaviour {

	public GameObject box;
	public float fireRate = 0.5f;
	private float nextFire = 0.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Time.time > this.nextFire) {

			this.nextFire = Time.time + fireRate;
			Instantiate (this.box, transform.position, Random.rotation);
		}
	}
}
