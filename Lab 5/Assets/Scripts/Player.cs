using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour {

	public enum CAction {None, Follow, Flee};
	public CAction cubeAction;

	public Transform player;
	public Transform cube;
	public Slider slider;
	public float speed;
	bool enter;

	private void OnTriggerEnter(Collider other)
	{
		enter = true;
	}

	private void OnTriggerExit(Collider other)
	{
		enter = false;
	}

	void Update () {

		float distance = Vector3.Distance(player.transform.position, transform.position);
		Vector3 localPosition = player.transform.position - transform.position;
		localPosition = localPosition.normalized;

		if (enter == true) {
			switch (cubeAction) {

			case CAction.None:
				cube.LookAt (player);
				print("none");
				break;
			case CAction.Follow:
				cube.LookAt (player);
				follow (localPosition);
				print("follow");
				break;
			case CAction.Flee:
				cube.LookAt (player);
				flee (localPosition);
				print("flee");
				break;
			}

			hpDecrease ();
		} else {
			hpIncrease ();
		}
	}
			
	public void follow (Vector3 localPosition) {
		cube.Translate (localPosition.x * speed * Time.deltaTime, 
			0.0f, localPosition.z * speed * Time.deltaTime);
	}

	public void flee (Vector3 localPosition){
		cube.Translate (localPosition.x * speed * Time.deltaTime * -1, 
			0.0f,
			localPosition.z * speed * Time.deltaTime * -1);
	}
		
	public void hpDecrease(){
		slider.value--;
	}

	public void hpIncrease(){
		slider.value++;
	}

}
