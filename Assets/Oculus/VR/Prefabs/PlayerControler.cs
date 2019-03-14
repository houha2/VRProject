using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour {
    public float thruster;
    public float yaw;
    public float pitch;
    public float roll;
    public GameObject ship;
	// Use this for initialization
	void Start () {
        thruster = 0.0f;
	}
	
	// Update is called once per frame
	void Update () {

        ship.transform.Rotate(pitch, yaw, roll, Space.Self);
        ship.GetComponent<Rigidbody>().velocity = transform.forward * thruster;
        if (Input.GetKey(KeyCode.UpArrow))
        {
            thruster += .01f;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            thruster -= .01f;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            pitch += .01f;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            pitch -= .01f;
        }
        if (Input.GetKey(KeyCode.A))
        {
            roll += .01f;
        }
        if (Input.GetKey(KeyCode.D))
        {
            roll -= .01f;
        }
        if (Input.GetKey(KeyCode.W))
        {
            yaw += .01f;
        }
        if (Input.GetKey(KeyCode.S))
        {
            yaw -= .01f;
        }
    }
}

