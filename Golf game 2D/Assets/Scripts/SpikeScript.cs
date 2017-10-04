﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpikeScript : MonoBehaviour {

    //int iCollisions = 0;

    Vector3 vLocalUp;
    // Use this for initialization
    void Start () {
        vLocalUp = transform.up;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            collision.gameObject.transform.position = GameObject.Find("SpawnPoint").transform.position;
        }

        if (collision.tag == "Player2")
        {
            collision.gameObject.transform.position = GameObject.Find("SpawnPoint2").transform.position;
        }

        collision.gameObject.GetComponent<PlayerController>().vLolImGoingToMakeTheForceZeroSoDaNiggaDunRunOffDaFukinEdgeLolFukinBallDontKnowHowToStandStill();
    }
}