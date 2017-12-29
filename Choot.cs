using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Choot : MonoBehaviour {

    public Transform initial;

    public GameObject boolet;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0)) {
            GameObject.Instantiate(boolet, initial);
        }
	}
}
