using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePhysics : MonoBehaviour {

	public float forceValue;
	public float jumpValue;
	private Rigidbody rigidbody;
	private AudioSource audio;

	// Use this for initialization
	void Start () {
		
		this.rigidbody = GetComponent<Rigidbody> ();
		this.audio = GetComponent<AudioSource> ();
	}

	// Update is called once per frame
	void Update () {
		
		if (Input.GetButtonDown ("Jump") && !this.isJumping()) {

			this.audio.Play ();
			this.rigidbody.AddForce (Vector3.up * jumpValue, ForceMode.Impulse);
		}
	}

	void FixedUpdate() {

		Vector3 forceVector = new Vector3 (Input.GetAxis ("Horizontal"), 0, Input.GetAxis ("Vertical"));
		this.rigidbody.AddForce (forceVector * this.forceValue);
	}

	private bool isJumping() {
		return !(Mathf.Abs (this.rigidbody.velocity.y) < 0.01f);
	}
}

