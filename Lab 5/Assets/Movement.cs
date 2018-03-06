//Keenan Myers
//Lab 2

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

	// Use this for initialization
	void Start () {
		print ("obligatory text");
	}
	
	// Update is called once per frame
	void Update () {
		
        // Call function to move camera with keyboard
        move ();
        
        // Hide and lock the cursor
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        
	}
    
    
    void move () {
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
        
        /*
        Commented out beause character rotation is not necessary
		// Rotate Left
		if (Input.GetKey (KeyCode.LeftArrow)) {
			transform.Rotate (0f, -2f, 0f);
		}
		// Rotate Right
		if (Input.GetKey (KeyCode.RightArrow)) {
			transform.Rotate (0f, 2f, 0f);
		} 
        */
        
        //Sensitivity
        float s = 2;
        
        //Look side to side
        float h = Input.GetAxis("Mouse X");
        transform.Rotate(0, s*h, 0);
        
        //Look up and down
        float g = Input.GetAxis("Mouse Y");
        transform.Rotate(-1*s*g, 0, 0);
    
    }
}
