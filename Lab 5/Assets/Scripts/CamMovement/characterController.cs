using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterController : MonoBehaviour {

    public float walkSpeed;
	public float runSpeed;
	private float speed;
	public GameObject playerObject;
	private Player player;

	// Use this for initialization
	void Start () {
        //Cursor.lockState = CursorLockMode.Locked;
		player = playerObject.GetComponent<Player> ();
	}
	
	// Update is called once per frame
	void Update () {
		float translation;
		float strafe;

		speed = walkSpeed;

		if (Input.GetKey ("left shift")) {
			speed = runSpeed;
			player.decrease (player.stamslider, player.stamDecrease);
			if (player.stamslider.value == 0) {
				speed = walkSpeed;
			}
				
		} else {
			player.increase (player.stamslider, player.stamIncrease);
		}



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
