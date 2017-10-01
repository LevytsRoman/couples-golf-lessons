using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballMovement : MonoBehaviour {
    //public int power;
    public Transform clubObj;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftControl)){
            GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
            //Instantiate(clubObj, transform.position, clubObj.rotation);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.Rotate(0, 10, 0);
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.Rotate(0, -10, 0);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody>().AddRelativeForce(0,0,350);
        } 
    }
    /*private void OnCollisionEnter(Collision collision)
    {
        collision.rigidbody.AddForce(-transform.forward * power);
        collision.rigidbody.useGravity = true;
    }*/
}
