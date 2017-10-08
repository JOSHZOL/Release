using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpikeScript : MonoBehaviour {

    //int iCollisions = 0;
    public GameObject SpawnController;
    public GameObject deathPartical;

    GameObject goPlayer;

    bool bStartDead;
    float fDeathTimer;
     
    Vector3 vLocalUp;
    // Use this for initialization
    void Start () {
        vLocalUp = transform.up;
        bStartDead = false;
        fDeathTimer = 0.05f;
    }
	
	// Update is called once per frame
	void Update ()
    {
	    if (bStartDead == true)
        {
            fDeathTimer -= Time.deltaTime;
        }

        if (fDeathTimer <= 0.0f)
        {
            bStartDead = false;
            goPlayer.GetComponent<PlayerController>().dead = false;
            fDeathTimer = 0.05f;
        }
	}

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<PlayerController>().dead == false)
        {
            Instantiate(deathPartical, collision.transform.position, Quaternion.identity);

            collision.gameObject.GetComponent<PlayerController>().vLolImGoingToMakeTheForceZeroSoDaNiggaDunRunOffDaFukinEdgeLolFukinBallDontKnowHowToStandStill();
            collision.gameObject.GetComponent<PlayerController>().dead = true;
            bStartDead = true;

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
