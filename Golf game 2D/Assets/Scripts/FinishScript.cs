using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishScript : MonoBehaviour {
    
    public bool bTouched = false;
    public GameObject particles;
    public AudioSource win;

    public string sceneToChangeTo;
    float fTimePassed = 0.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {    
		if (bTouched)
        {
            fTimePassed += Time.deltaTime;

            if (fTimePassed > 2.5f)
            {
                SceneManager.LoadScene(sceneToChangeTo);
            }
        }
	}

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player" || collision.tag == "Player2")
        {
            if (bTouched == false)
            {
                particles.SetActive(true);
                win.Play();
                bTouched = true;

                if (collision.GetComponent<PlayerController>().jumpButton != "space")
                {
                    if (collision.tag == "Player2")
                    {
                        GameObject.Find("Score").GetComponent<ScoreScript>().iAddScore(true);
                    }
                    else
                    {
                        GameObject.Find("Score").GetComponent<ScoreScript>().iAddScore(false);
                    }
                }
            }

            collision.gameObject.GetComponent<PlayerController>().bCanMove = false;
            collision.gameObject.GetComponent<Rigidbody2D>().velocity = Vector3.zero;
            collision.gameObject.GetComponent<Animator>().SetBool("Land", true);
            collision.gameObject.GetComponent<PlayerController>().bJumpReady = true;
        }
    }
}
