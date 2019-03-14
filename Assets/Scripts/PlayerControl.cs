using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerControl : MonoBehaviour
{
    public float thruster;
    public float yaw;
    public float pitch;
    public float roll;
    static float speed;
    static float change;
    static float limit;
    public GameObject ship;
    // Use this for initialization
    void Start()
    {
        thruster = 0.0f;
        speed = 0.5f;
        change = 0.01f;
        limit = 1.0f;
    }

    // Update is called once per frame
    void Update()
    {

        ship.transform.Rotate(pitch, yaw, roll, Space.Self);
        ship.GetComponent<Rigidbody>().velocity = transform.forward * thruster;
        if (Input.GetKey(KeyCode.UpArrow))
        {
            thruster += speed;
            if (thruster > 150)
                thruster = 150;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            thruster -= speed;
            if (thruster < 0)
                thruster = 0;
        }
        if (Input.GetKey(KeyCode.W))
        {
            pitch -= change;
            if (pitch < -limit)
                pitch = -limit;
        }
        if (Input.GetKey(KeyCode.S))
        {
            pitch += change;
            if (pitch > limit)
                pitch = limit;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            roll += change;
            if (roll > limit)
                roll = limit;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            roll -= change;
            if (roll < -limit)
                roll = -limit;
        }
        if (Input.GetKey(KeyCode.D))
        {
            yaw += change;
            if (yaw > limit)
                yaw = limit;
        }
        if (Input.GetKey(KeyCode.A))
        {
            yaw -= change;
            if (yaw < -limit)
                yaw = -limit;
        }


        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("StartMenu", LoadSceneMode.Single);
        }





    }
}

