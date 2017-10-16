using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishScript : MonoBehaviour {

    bool bPlayer1 = false;
    bool bPlayer2 = false;
    public bool bTouched = false;
    public GameObject particles;
    public AudioSource win;

    public string sceneToChangeTo;
    float fTimePassed = 0.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        fTimePassed += Time.deltaTime;
		if (bPlayer1 || bPlayer2)
        {   
            if (fTimePassed > 1.5f)
            {
                print("Finished");
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

                if (collision.tag == "Player2")
                {
                    GameObject.Find("Score").GetComponent<ScoreScript>().iAddScore(true);
                }
                else
                {
                    GameObject.Find("Score").GetComponent<ScoreScript>().iAddScore(false);
                }
            }

            fTimePassed = 0.0f;
            bPlayer1 = true;

            collision.gameObject.GetComponent<PlayerController>().bCanMove = false;
            collision.gameObject.GetComponent<Rigidbody2D>().velocity = Vector3.zero;
            collision.gameObject.GetComponent<Animator>().SetBool("Land", true);
        }
    }
}
