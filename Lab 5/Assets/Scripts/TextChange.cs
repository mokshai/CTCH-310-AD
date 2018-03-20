using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextChange : MonoBehaviour {


	public void Change (float f) {
		GetComponent<Text>().text = f.ToString ();
	}
}
