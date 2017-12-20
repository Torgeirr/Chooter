using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    public Rigidbody rb;

    public float speed = 15f;

    public GameObject player;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        float MoveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(MoveHorizontal, 0.0f, moveVertical);

        GetComponent<Rigidbody>().velocity = movement * speed;

        //rigidbody.position - new Vector3()
    }
}