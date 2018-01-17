using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BooletVelocity : MonoBehaviour {

	public bool shot = false;

	public Rigidbody rb;

	public float speed = 10;

	// Use this for initialization
	void Start () {
		if (GameObject.Find ("Player").GetComponent<Choot> ().booletChot == true) {
			shot = true;
		}
	}
	
	// Update is called once per frame
	void Update () {
		giveBooletVelocity ();
	}

	public void giveBooletVelocity () {
		if (shot == true)
		{
			rb.velocity = new Vector3(speed * -10, 0, 0);
		}
	}
		
	public void OnCollisionEnter (Collision other) {
		Debug.Log ("Process Run");
		if(other.gameObject == GameObject.FindWithTag("P2")) {
            GameObject.Find("P2").GetComponent<P2Chooter>().Health -= 15;
            Debug.Log(GameObject.Find("P2").GetComponent<P2Chooter>().Health);

        }
	}
}
