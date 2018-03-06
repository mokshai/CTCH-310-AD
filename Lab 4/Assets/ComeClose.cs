using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComeClose : MonoBehaviour {

	public float moveSpeed;
	Vector3 radius = Vector3(5.0f, 0.0f, 5.0f);
	Vector3 mainCam;
	Vector3 hellephant;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		mainCam = GameObject.Find ("Main Camera").transform.position;
		hellephant = GameObject.Find ("Hellephant").transform.position;

		move ();
	}

	void move () {
		if ((mainCam - hellephant) > radius.x){
			transform.Translate (moveSpeed, 0.0f, 0.0f);
		}

	}

}
