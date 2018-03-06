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
			cube.LookAt (capsule);
			transform.Translate (localPosition.x * speed * Time.deltaTime, 
				0.0f,
				localPosition.z * speed * Time.deltaTime);
		}


	}
}
