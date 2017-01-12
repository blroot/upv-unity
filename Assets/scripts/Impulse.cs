using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Impulse : MonoBehaviour {

	public float forceImpulse = 0.5f;

	// Use this for initialization
	void Start () {

		this.GetComponent<Rigidbody> ().AddForce (Vector3.up * forceImpulse, ForceMode.Impulse);
	}
	
	// Update is called once per frame
	void Update () {

		if (this.transform.position.y < 0.0f) {
			
			Destroy (gameObject);
		}
	}
}
