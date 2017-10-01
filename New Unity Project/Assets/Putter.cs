using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Putter : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GetComponent<ConstantForce>().enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space)) {
            GetComponent<ConstantForce>().enabled = true;
        }
	}
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }
}
