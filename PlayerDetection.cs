using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDetection : MonoBehaviour {

    public Gameobject Npc;

    public Vector3 distanceBetween;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        distanceBetween = newVector3(Npc - gameobject.other);

        if (distanceBetween <= 15) {
            Debug.Log("Dialogue Box Popped Up");
        }
		
	}
}
