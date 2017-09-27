using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour {

    public GameObject Player1;
    public GameObject Player2;
    public Camera cam;
    public float camSpeed;
    public float fSize;
    public float fDivide;

    Vector3 positionToMoveTo;
    float fDistance;
    float fSizeDifference;
    float SpeedMultiplier;
    float ShrinkMultiplier;
    float camSize;
    // Use this for initialization
    void Start () {
	    	
	}
	
	// Update is called once per frame
	void Update () {

        // distance between players
        if (Player1.transform.position.x > Player2.transform.position.x)
        {
            fDistance = Player1.transform.position.x - Player2.transform.position.x;
        }
        else
        {
            fDistance =  Player2.transform.position.x - Player1.transform.position.x;
        }

        positionToMoveTo = new Vector3((Player1.transform.position.x + Player2.transform.position.x) / 2 + 4, transform.position.y, -10);

        camSize = fSize + fDistance / fDivide;

        // get size different between current and desired  
        fSizeDifference = Mathf.Abs(cam.orthographicSize - camSize);

        // change shrink speed
        if (fSizeDifference < 10)
        {
            ShrinkMultiplier = fSizeDifference / 10;
        }
        else
        {
            ShrinkMultiplier = 1.0f;
        }

        // change camera size
        if (cam.orthographicSize > camSize)
        {
            cam.orthographicSize = cam.orthographicSize - (1.0f * ShrinkMultiplier);
        }
        else
        {
            cam.orthographicSize = cam.orthographicSize + (1.0f * ShrinkMultiplier);
        }

        // get distance from camera to destination 
        if (transform.position.x > positionToMoveTo.x)
        {
            fDistance = transform.position.x - positionToMoveTo.x;
        }
        else
        {
            fDistance = positionToMoveTo.x - transform.position.x;
        }

        // change move speed
        if (fDistance < 1000)
        {
            SpeedMultiplier = fDistance / 400;
        }
        else
        {
            SpeedMultiplier = 1.0f;
        }

        // change camera position
        if (positionToMoveTo.x < cam.transform.position.x)
        {
            cam.transform.position = cam.transform.position - (transform.right * camSpeed * SpeedMultiplier);
        }
        else if (positionToMoveTo.x > cam.transform.position.x)
        {
            cam.transform.position = cam.transform.position + (transform.right * camSpeed * SpeedMultiplier);
        }
    }
}
