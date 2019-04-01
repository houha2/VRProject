using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballon : MonoBehaviour {
    static float timer;
    static bool hit;
    static float max = 5.0f;
    // Use this for initialization
    void Start () {
        hit = false;
        timer = 0.0f;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(hit == false)
        {
            timer = 0.0f;
            this.GetComponent<MeshRenderer>().enabled = false;
            scoreScript.score += 1;
            hit = true;
        }
        
        
    }
    // Update is called once per frame
    void Update () {
        timer += Time.deltaTime;
        if (timer  >=  max)
        {
            this.GetComponent<MeshRenderer>().enabled = true;
            
            hit = false;
        }
	}
}
