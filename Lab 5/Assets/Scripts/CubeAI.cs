/* Keenan Myers
 * March 13 2018
 * CTCH 310 AD
 * 
 * CubeAI.cs
 * Has option to follow, flee or do nothing to a target.
 * In every case, cube will rotate towards target.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeAI : MonoBehaviour {

	public enum CubeAction {None, Follow, Flee};
	public CubeAction cubeAI;

	public Transform self;
	public Transform target;

	public float rotSpeed;
	public float moveSpeed;

	SphereCollider selfCollider;

	public void Start () {
		selfCollider = self.transform.GetComponent<SphereCollider> ();
	}

	public void Update () {
		float distance = Vector3.Distance(target.transform.position, transform.position);
		Vector3 localPosition = (target.transform.position - self.transform.position).normalized;

		if (distance < selfCollider.radius) {
			switch (cubeAI) {
				case CubeAction.None:
					Rotate ();
					break;
				case CubeAction.Follow:
					Rotate ();
					Follow ();
					break;
				case CubeAction.Flee:
					Rotate ();
					Flee ();
					break;
			}
		}
	}

	public void Follow () {
		self.transform.Translate (Vector3.forward * moveSpeed * Time.deltaTime);
	}

	public void Flee () {
		self.transform.Translate (Vector3.back * moveSpeed * Time.deltaTime);
	}

	public void Rotate () {
		Quaternion lookRotation = Quaternion.LookRotation ((target.transform.position - self.transform.position).normalized);
		self.transform.rotation = Quaternion.Slerp(self.transform.rotation, lookRotation, Time.deltaTime * rotSpeed);

		Vector3 currentRotation = self.transform.localRotation.eulerAngles;
		currentRotation.x = Mathf.Clamp (currentRotation.x, 0f, 0f);
		currentRotation.z = Mathf.Clamp (currentRotation.z, 0f, 0f);
		self.transform.localRotation = Quaternion.Euler (currentRotation);
	}

	void OnValidate () {
		if (rotSpeed < 0) {
			rotSpeed = 0;
		}
		if (moveSpeed < 0) {
			moveSpeed = 0;
		}
	}
}
