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
		cube.LookAt (player);

		if (enter == true) {
			switch (cubeAction) {

			case CAction.None:
				print("none");
				break;
			case CAction.Follow:
				follow ();
				print("follow");
				break;
			case CAction.Flee:
				flee ();
				print("flee");
				break;
			}

			hpDecrease ();
		} else {
			hpIncrease ();
		}
	}
			
	public void follow () {
		cube.Translate(0f, 0f, 1f * speed * Time.deltaTime);
	}

	public void flee (){
		cube.Translate(0f, 0f, -1f * speed * Time.deltaTime);
	}
		
	public void hpDecrease(){
		slider.value--;
	}

	public void hpIncrease(){
		slider.value++;
	}

}
