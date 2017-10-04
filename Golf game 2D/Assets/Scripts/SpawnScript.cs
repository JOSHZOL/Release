using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour {

    public string SpawnPlayer1;
    public string SpawnPlayer2;

    public GameObject Player1;
    public GameObject Player2;

    // Use this for initialization
    void Start ()
    {
        if (Random.Range(0, 2) == 0)
        {
            SpawnPlayer1 = "SpawnPoint";
            SpawnPlayer2 = "SpawnPoint2";
        }
        else
        {
            SpawnPlayer1 = "SpawnPoint2";
            SpawnPlayer2 = "SpawnPoint";
        }

        Player1.gameObject.transform.position = GameObject.Find(SpawnPlayer1).transform.position;
        Player2.gameObject.transform.position = GameObject.Find(SpawnPlayer2).transform.position;
        
    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
