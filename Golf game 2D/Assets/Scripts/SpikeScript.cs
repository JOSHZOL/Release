using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpikeScript : MonoBehaviour
{
    GameObject goPlayer;
    //Vector3 vLocalUp;
    
    float fDeathTimer;

    public GameObject SpawnController;
    public GameObject deathPartical;

    // Use this for initialization
    void Start ()
    {
        //vLocalUp = transform.up;
        fDeathTimer = 0.05f;
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (goPlayer != null)
        {
            if (goPlayer.GetComponent<PlayerController>().dead)
            {
                fDeathTimer -= Time.deltaTime;
            }

            if (fDeathTimer <= 0.0f)
            {
                goPlayer.GetComponent<PlayerController>().dead = false;
                fDeathTimer = 0.05f;
            }
        }
	}

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<PlayerController>().dead == false)
        {
            Instantiate(deathPartical, collision.transform.position, Quaternion.identity);

            collision.gameObject.GetComponent<PlayerController>().vStayStill();
            collision.gameObject.GetComponent<PlayerController>().dead = true;

            goPlayer = collision.gameObject;

            if (collision.tag == "Player")
            {
                collision.gameObject.transform.position = GameObject.Find(SpawnController.GetComponent<SpawnScript>().SpawnPlayer1).transform.position;
            }

            if (collision.tag == "Player2")
            {
                collision.gameObject.transform.position = GameObject.Find(SpawnController.GetComponent<SpawnScript>().SpawnPlayer2).transform.position;
            }
        }
    }
}
