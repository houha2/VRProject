using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreScript : MonoBehaviour {

    public static int score;
	// Use this for initialization
	void Start () {
        score = 0;
	}
	
    
	// Update is called once per frame
	void Update () {
        this.GetComponent<TextMesh>().text = "Score\n" + score.ToString();
	}
}
