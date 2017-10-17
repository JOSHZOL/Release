using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SugarScript : MonoBehaviour {

    float fDeadTimer;

	// Use this for initialization
	void Start () {
        fDeadTimer = 0.0f;
	}
	
	// Update is called once per frame
	void Update ()
    {
        fDeadTimer += Time.deltaTime;

        if (fDeadTimer > 5.0f)
        {
            Destroy(gameObject);
        }
	}

    void OnTriggerEnter2D(Collider2D collision)
    {
    }
}
