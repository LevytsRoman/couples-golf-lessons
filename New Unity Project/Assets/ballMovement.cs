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
            Instantiate(clubObj, transform.position, clubObj.rotation);
        }
    }
    /*private void OnCollisionEnter(Collision collision)
    {
        collision.rigidbody.AddForce(-transform.forward * power);
        collision.rigidbody.useGravity = true;
    }*/
}
