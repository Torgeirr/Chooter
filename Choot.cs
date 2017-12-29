using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Choot : MonoBehaviour {

    public Transform initial;

    public GameObject boolet;

    public Rigidbody rb;

    public bool booletChot = false;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0)) {
            GameObject.Instantiate(boolet, initial);

            booletChot = true;

        }

        if (booletChot == true)
        {
            rb.velocity = new Vector3(0, 0, 100);
        }
        else {
            return;
        }
    }
}
