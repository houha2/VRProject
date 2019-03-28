using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetSphere : MonoBehaviour {
    public int lives = 3;
	// Use this for initialization
    public void Damage(int damageDone)
    {
        lives -= damageDone;
        if(lives <= 0)
        {
            gameObject.SetActive(false);
        }
    }
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
