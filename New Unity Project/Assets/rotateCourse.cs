using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateCourse : MonoBehaviour {

    public float amount = 50f;
    private Rigidbody rig;
    void Start() {
        rig = GetComponent<Rigidbody>();
    }
    void FixedUpdate()
    {
     /*   float h = 0;// = Input.GetAxis("Horizontal") * amount * Time.deltaTime;
        float v = 0;// = Input.GetAxis("Vertical") * amount * Time.deltaTime;
        if (Input.GetKey(KeyCode.UpArrow))
        {
            print("heyo!!!");
            h = 100;
        }
        else if (Input.GetKey(KeyCode.RightArrow)) {
            v = 100;
        }

        print(h);

        rig.AddTorque(transform.up * h);

        rig.AddTorque(transform.right * v);*/
    }
}
