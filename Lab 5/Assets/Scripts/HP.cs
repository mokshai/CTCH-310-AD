using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HP : MonoBehaviour {

	public Slider hpslider;

	public void hpDecrease () {

		hpslider.value--;
	}

}
