/* runaway.cs
 * Keenan Myers
 * GameObject runs away from player
 * CTCH 310AD
*/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class runaway : MonoBehaviour 
{

	public float speed;
	public GameObject player;
	//public Transform  capsule;
	//public Transform cube;

	// Use this for initialization
	void Start () 
	{

	}

	// Update is called once per frame
	void Update () 
	{
		float distance = Vector3.Distance(player.transform.position, transform.position);
		Vector3 localPosition = player.transform.position - transform.position;
		localPosition = localPosition.normalized;

		if (distance < 5)
		{
			//cube.LookAt (capsule);
			transform.Translate (localPosition.x * speed * Time.deltaTime * -1, 
				0.0f,
				localPosition.z * speed * Time.deltaTime * -1);
		}


	}
}