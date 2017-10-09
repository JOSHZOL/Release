using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScoreScript : MonoBehaviour {

    public GameObject BlueScore;
    public GameObject CremeScore;

    // Use this for initialization
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        BlueScore.GetComponent<Text>().text = ScoreScript.iBlueScore.ToString();
        CremeScore.GetComponent<Text>().text = ScoreScript.iCremeScore.ToString();
    }
}
