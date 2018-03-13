/* follow.cs
 * Keenan Myers
 * GameObject moves towards player
 * CTCH 310AD
*/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow : MonoBehaviour 
{

	public float speed;
	public GameObject player;
	public Transform  capsule;
	public Transform cube;
	public bool radBool;
	public HP playerHP;

	// Use this for initialization
	void Start () 
	{
		radBool = false;
	}

	// Update is called once per frame
	void Update () 
	{
		float distance = Vector3.Distance(player.transform.position, transform.position);
		Vector3 localPosition = player.transform.position - transform.position;
		localPosition = localPosition.normalized;

		inRadius (distance, radBool);
		if (inRadius (distance, radBool))
		{
			followPlayer (localPosition);
			playerHP.hpDecrease ();
		}
	}

	public bool inRadius (float distance, bool radBool) {
		if (distance < 5) {
			return true;
		} else {
			return false; 
		}
	}

	public void followPlayer (Vector3 localPosition) {
		cube.LookAt (capsule);
		transform.Translate (localPosition.x * speed * Time.deltaTime, 
			0.0f, localPosition.z * speed * Time.deltaTime);
	}
}
