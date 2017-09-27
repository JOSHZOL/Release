using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreScript : MonoBehaviour {

    static public int iBlueScore = 0;
    static public int iCremeScore = 0;
   

    // Use this for initialization
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {

	}

    public void iAddScore(bool isBlue)
    {
        if (isBlue == true)
        {
            iBlueScore += 1;
        }
        else
        {
            iCremeScore += 1;
        }
    }
}
