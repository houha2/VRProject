using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour {

    public GameObject projectile;
    public GameObject ship;
    static float bulletspeed = 4000.0f;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetAxis("Oculus_GearVR_RIndexTrigger") > 0.0f || Input.GetKeyDown(KeyCode.Space))
        {
            GameObject clone = Instantiate(projectile, ship.transform.position, ship.transform.rotation);
            clone.GetComponent<Rigidbody>().AddForce(clone.transform.forward * bulletspeed);

            Destroy(clone, 3);
        }
        
	}

}
