using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dontDie : MonoBehaviour {

    static bool musicPlaying = false;

	// Use this for initialization
	void Start ()
    {
	    if (!musicPlaying)
        {
            GetComponent<AudioSource>().Play();
            musicPlaying = true;
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }
}
