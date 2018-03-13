using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterController : MonoBehaviour {

    public float speed;

	// Use this for initialization
	void Start () {
        Cursor.lockState = CursorLockMode.Locked;
	}
	
	// Update is called once per frame
	void Update () {
		float translation;
		float strafe;

		if (((Input.GetAxis("Vertical")) != 0) && (Input.GetAxis("Horizontal") != 0))
			{
				translation = Input.GetAxis("Vertical") * speed * 0.5f;
				strafe = Input.GetAxis("Horizontal") * speed * 0.5f ;
			}
		else
			{
				translation = Input.GetAxis("Vertical") * speed;
				strafe = Input.GetAxis("Horizontal") * speed;
			}


        translation *= Time.deltaTime;
        strafe *= Time.deltaTime;

        transform.Translate(strafe, 0, translation);

        if (Input.GetKeyDown("escape"))
        {
            Cursor.lockState = CursorLockMode.None;
        }
    }
}
