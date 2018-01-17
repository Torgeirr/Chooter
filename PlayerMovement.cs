using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public Rigidbody rb;
	public GameObject player;


    private enum rotation {North, South, East, West};
    private rotation currentRot;

    public float nRot = 0.0f;
    public float sRot = 180.0f;
    public float eRot = 90.0f;
    public float wRot = 270.0f;

    public float speed = 15f;

    //Rotation and Movement Controls
	void Update () {
        if (Input.GetKeyDown("w"))
        {          
            rotationNorth();
        }

        if (Input.GetKeyDown("s"))
        {
            rotationSouth();
        }

        if (Input.GetKeyDown("d"))
        {
            rotationEast();
        }

        if (Input.GetKeyDown("a"))
        {
            rotationWest();
        }

        float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(-moveVertical, 0.0f, moveHorizontal);

        GetComponent<Rigidbody>().velocity = movement * speed;        
	}



    //Direction functions
    void rotationNorth()
    {
        transform.eulerAngles = new Vector3(0, nRot, 0);
    }

    void rotationSouth()
    {
        transform.eulerAngles = new Vector3(0, sRot, 0);
    }

    void rotationEast()
    {
        transform.eulerAngles = new Vector3(0, eRot, 0);
    }

    void rotationWest()
    {
        transform.eulerAngles = new Vector3(0, wRot, 0);
    }

    
}