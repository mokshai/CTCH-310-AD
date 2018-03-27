using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoosting : MonoBehaviour {

	public AudioClip bulletAudio;
	public GameObject bulletPrefab;

	private AudioSource source;
	private float volumeLowRange = 0.5f;
	private float volumeHighRange = 1.0f;

	void Awake () {
		source = GetComponent<AudioSource> ();
	}

	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			Fire ();
		}
	}

	void Fire () {
		float volume = Random.Range (volumeLowRange, volumeHighRange);
		source.PlayOneShot (bulletAudio, volume);
	}

}
