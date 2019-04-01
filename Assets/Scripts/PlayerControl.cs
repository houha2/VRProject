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


    static float fireRate;
    static float weaponRange;
    static float speed;
    static float change;
    static float limit;
    static Vector3 current_rotate;
    private float timeCount = 0.0f;
    
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

       
        if (OVRInput.Get(OVRInput.Button.PrimaryThumbstickUp))// (Input.GetAxis("Oculus_GearVR_RIndexTrigger") > 0.0f)
        {
            thruster += speed;
            if (thruster > 150)
                thruster = 150;
      
        }
        else // (Input.GetAxis("Oculus_GearVR_RIndexTrigger") <= 0.0f)
        {
            thruster -= speed;
            if (thruster < 0)
                thruster = 0;
         
        }
        var step = speed * Time.deltaTime;

        ship.transform.rotation = Quaternion.Slerp(ship.transform.rotation, OVRInput.GetLocalControllerRotation(OVRInput.Controller.RTouch), timeCount ) ;
        timeCount += Time.deltaTime;
        ship.GetComponent<Rigidbody>().velocity = transform.forward * thruster;

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("StartMenu", LoadSceneMode.Single);
        }





    }
}

