using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateClub : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.Rotate(0, 10, 0);
        } else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.Rotate(0, -10, 0);
        }
    }
}
