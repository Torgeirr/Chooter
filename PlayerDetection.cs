using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDetection : MonoBehaviour {

    public Transform Npc;

    public Transform player;

    public Vector3 distanceBetween;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Vector3.Distance(player.position, this.transform.position) <= 15) {

            Debug.Log("Distance Closed");
        }
        /*distanceBetween = newVector3(Npc - gameObject.other);

        if (distanceBetween <= 15) {
            Debug.Log("Dialogue Box Popped Up");
        }*/
		
	}
}
