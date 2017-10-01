using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballMovement : MonoBehaviour {
    //public int power;
    public Transform clubObj;
    public Transform arrowObj;
    public float speed = 100;

    private void Update()
    {
        // Reset for next shot
        if (Input.GetKeyDown(KeyCode.LeftControl)){
            GetComponent<Rigidbody>().velocity =Vector3.zero;
            GetComponent<Transform>().eulerAngles = new Vector3(0, 0, 0);
            //Instantiate(arrowObj, transform.position, arrowObj.rotation);
            arrowObj.GetComponent<Transform>().position = transform.position;
        }
        // Angle of shot
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.Rotate(0, -10, 0);
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.Rotate(0, 10, 0);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody>().AddRelativeForce(speed,0,0);
        }

        // Power of shot
        if (Input.GetKey(KeyCode.UpArrow)) {
            if (speed < 1000)
            {
                speed += 5;
            } else {
                speed = 1000;
            }
        } else if (Input.GetKey(KeyCode.UpArrow))
        {
            if (speed > 5)
            {
                speed -= 5;
            } else
            {
                speed = 1;
            }
        }
    }
    /*private void OnCollisionEnter(Collision collision)
    {
        collision.rigidbody.AddForce(-transform.forward * power);
        collision.rigidbody.useGravity = true;
    }*/
}
