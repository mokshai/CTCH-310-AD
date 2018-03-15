using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Underwater : MonoBehaviour {

	public GameObject playerObject;
	public float waterLevel;
	private bool isUnderwater;
	private Color normalColour;
	private Color underwaterColour;
	private Player player;


	void Start () {
		normalColour = new Color (.9f, .9f, .9f);
		underwaterColour = new Color (0.22f, 0.65f, 0.77f);
		SetNormal ();
		player = playerObject.GetComponent<Player> ();
	}

	void Update () {
		if ((transform.position.y < waterLevel) != isUnderwater) {
			isUnderwater = transform.position.y < waterLevel;
			if (isUnderwater) {
				SetUnderwater ();

			}
			if (!isUnderwater) {
				SetNormal ();
			}
		}

		if (transform.position.y < waterLevel) {
			player.decrease (player.oxslider, player.oxygenDecrease);	
		} else {
			player.increase (player.oxslider, player.oxygenIncrease);
		}

	}

	private void SetUnderwater () {
		RenderSettings.fogColor = underwaterColour;
		RenderSettings.fogDensity = 0.03f;
	}

	private void SetNormal () {
		RenderSettings.fogColor = normalColour;
		RenderSettings.fogDensity = 0.0010f;
	}
}
