using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDetection : MonoBehaviour {

    public Transform Npc;

    public Transform player;

    public Vector3 distanceBetween;

    public GameObject DiaBox;

	// Use this for initialization
	void Start () {
        DiaBox.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {

        if (Vector3.Distance(player.position, this.transform.position) <= 15) {

            Debug.Log("Distance Closed");

            DiaBox.SetActive(true);
        }

        if (Vector3.Distance(player.position, this.transform.position) > 15)
        {

            Debug.Log("Distance Closed");

            DiaBox.SetActive(false);
        }


    }
}
