using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrowControl : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.Rotate(0, 0, 10);
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.Rotate(0, 0, -10);
        }

        /*if (Input.GetKeyDown(KeyCode.Space))
        {
            Destroy(gameObject);
        }*/
        if (Input.GetKeyDown(KeyCode.LeftControl)) {
            GetComponent<Transform>().eulerAngles = new Vector3(90, 0, 270);
        }
    }
}
