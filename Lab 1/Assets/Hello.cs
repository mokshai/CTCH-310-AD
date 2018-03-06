//Keenan Myers
//Lab 1

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hello : MonoBehaviour {

	// Use this for initialization
	void Start () {
		print ("obligatory text");
	}
	
	// Update is called once per frame
	void Update () {
		//Move Forwards
		if (Input.GetKey (KeyCode.W)) {
			transform.Translate (0f, 0f, 0.1f);
		}
		// Move Backwards
		if (Input.GetKey (KeyCode.S)) {
			transform.Translate (0f, 0f, -0.1f);
		}
		// Strafe Left
		if (Input.GetKey (KeyCode.A)) {
			transform.Translate (-0.1f, 0f, 0f);
		}
		// Strafe Right
		if (Input.GetKey (KeyCode.D)) {
			transform.Translate (0.1f, 0f, 0f);
		}
		// Rotate Left
		if (Input.GetKey (KeyCode.LeftArrow)) {
			transform.Rotate (0f, -2f, 0f);
		}
		// Rotate Right
		if (Input.GetKey (KeyCode.RightArrow)) {
			transform.Rotate (0f, 2f, 0f);
		}
	}
}
