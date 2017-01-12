using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eruption : MonoBehaviour {

	public GameObject box;
	public float fireRate = 0.5f;

	// Use this for initialization
	void Start () {

		StartCoroutine (ThrowBox());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	IEnumerator ThrowBox() {

		yield return new WaitForSeconds (2.0f);

		while (true) {
			Instantiate (this.box, this.transform.position, Random.rotation);
			yield return new WaitForSeconds(this.fireRate);
		}
	}

}
