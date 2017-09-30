using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballMovement : MonoBehaviour {
    public int power;

    private void OnCollisionEnter(Collision collision)
    {
        collision.rigidbody.AddForce(-transform.forward * power);
        collision.rigidbody.useGravity = true;
    }
}
