/* Keenan Myers
 * March 13 2018
 * CTCH 310 AD
 * 
 * Player.cs
 * Currently only decreases slider value in a trigger
 * or increases out of trigger.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour {

	public Transform player;
	public float decreaseAmount;
	public float increaseAmount;
	public Slider slider;
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

		if (enter == true) {
			hpDecrease ();
		} else {
			hpIncrease ();
		}
	}

	public void hpDecrease(){
		slider.value -= decreaseAmount*Time.deltaTime;
	}

	public void hpIncrease(){
		slider.value += increaseAmount*Time.deltaTime;
	}

}
