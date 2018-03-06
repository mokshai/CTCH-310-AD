using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConversationScript : MonoBehaviour {

	public int iq = 5;

	void Start () {
		Greet ();
	}

	void Update () {
	}

	void Greet () {
		switch (iq) {
		case 5:
			print ("meme 5");
			break;
		case 4:
			print ("meme 4");
			break;
		case 3:
			print ("meme 3");
			break;
		case 2:
			print ("meme 2");
			break;
		case 1:
			print ("meme 1");
			break;
		case 0:
			print ("404 meme not found");
			break;
		}

	}

}
