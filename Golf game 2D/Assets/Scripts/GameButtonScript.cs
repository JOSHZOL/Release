using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameButtonScript : MonoBehaviour {

    public GameObject fan;
    public GameObject push;
    public GameObject pull;
    public float delaysize;

    bool on = false;
    float Delay = 0.0f;

    // Use this for initialization
    void Start ()
    {

	}
	
	// Update is called once per frame
	void Update ()
    {
        if (on)
        {
            Delay += Time.deltaTime;
        }

        if (Delay > delaysize)
        {
            on = false;
            fan.GetComponent<FanScript>().fFanForce = fan.GetComponent<FanScript>().fFanForce * -1;
            
            pull.SetActive(false);
            push.SetActive(true);
            Delay = 0.0f;
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Drop")
        {
            if (on == false)
            {
                fan.GetComponent<FanScript>().fFanForce = fan.GetComponent<FanScript>().fFanForce * -1;
                Destroy(collision.gameObject);

                on = true;

                pull.SetActive(true);
                push.SetActive(false);
            }
        }
    }

}
