using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

	public float speed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (Input.GetAxis ("Horizontal") * Time.deltaTime * this.speed, 0, 
							 Input.GetAxis ("Vertical") * Time.deltaTime * this.speed);
	}
}
