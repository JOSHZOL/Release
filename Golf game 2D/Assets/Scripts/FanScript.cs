using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FanScript : MonoBehaviour {

    public float fFanForce;
    Vector3 vLocalUp;

	// Use this for initialization
	void Start () {
        vLocalUp = transform.up;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerStay2D(Collider2D collider)
    {
        collider.GetComponent<Rigidbody2D>().AddForce(vLocalUp * fFanForce);
    }
}
