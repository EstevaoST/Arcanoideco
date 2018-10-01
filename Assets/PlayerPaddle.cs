using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPaddle : MonoBehaviour {

    public Rigidbody myRigidbody;
    public float speed = 5;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float xinput = Input.GetAxis("Horizontal");

        myRigidbody.velocity = transform.right * xinput * speed;

	}
}
