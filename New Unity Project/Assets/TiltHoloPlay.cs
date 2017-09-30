using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiltHoloPlay : MonoBehaviour {

    float speed = 50;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float actualSpeed = speed * Time.deltaTime;

        if (Input.GetKey(KeyCode.W))
        {
            transform.Rotate(actualSpeed, 0, 0);

        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.Rotate(-actualSpeed, 0, 0);

        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, actualSpeed, 0);

        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, -actualSpeed, 0);

        }
        else if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(0, 0, actualSpeed);

        }
        else if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(0, 0, -actualSpeed);

        }
    }
}
