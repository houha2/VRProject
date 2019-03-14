using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShipCollision : MonoBehaviour {
    public bool hello;
	// Use this for initialization
	void Start () {
        hello = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter(Collision collision)
    {
        hello = true;
        SceneManager.LoadScene("StartMenu", LoadSceneMode.Single);

    }
}
