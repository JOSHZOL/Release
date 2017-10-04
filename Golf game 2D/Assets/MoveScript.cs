using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour {

    public GameObject goBackGround;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        goBackGround.transform.Rotate(Vector3.forward * 20 * Time.deltaTime);
    }
}
