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
	public float hpDecrease;
	public float hpIncrease;
	public float oxygenDecrease;
	public float oxygenIncrease;
	public float stamDecrease;
	public float stamIncrease;
	public Slider hpslider;
	public Slider stamslider;
	public Slider oxslider;


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
			decrease (hpslider, hpDecrease);
		} else {
			increase (hpslider, hpIncrease);
		}
	}

	public void decrease(Slider slider, float amount){
		slider.value -= amount*Time.deltaTime;
	}

	public void increase(Slider slider, float amount){
		slider.value += amount*Time.deltaTime;
	}



}
