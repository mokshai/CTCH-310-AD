using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inRadius : MonoBehaviour {

    public Transform sphere;
    public Transform capsule;
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

    private void Update()
    {
        if (enter == true)
        {
            sphere.LookAt(capsule);
            //sphere.Translate(Vector3.forward * speed * Time.deltaTime);
            //sphere.Translate(0f, 0f, 1f * speed * Time.deltaTime);
        }
    }
}
