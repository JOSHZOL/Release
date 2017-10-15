using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour {

    public GameObject Player1;
    public GameObject Player2;
    public Camera cam;
    
    public float fSize;
    public float fDivide;
    
    Vector3 positionToMoveTo;

    float fStartTime = 0.0f;
    public float fInitialCamSpeed;
    public float fFinalCamSpeed;

    float fCamSpeed;
    float fProximitySlowDown;
    float fProximityNumba2;
    float fDistanceX;
    float fDistanceY;

    float SpeedMultiplierX;
    float SpeedMultiplierY;

    float fSizeDifference;
    float ShrinkMultiplier;
    float camSize;

    // Use this for initialization
    void Start () {
        fCamSpeed = fInitialCamSpeed;
        fProximitySlowDown = 10;
        fProximityNumba2 = fProximitySlowDown;
    }
	
	// Update is called once per frame
	void Update () {

        fStartTime += Time.deltaTime;

        if(Input.GetKeyDown("s") || Input.GetKeyDown("k"))
        {
            fCamSpeed = fFinalCamSpeed;
            fProximitySlowDown = 1000;
            fProximityNumba2 = 400;
        }

        // distance between players X
        if (Player1.transform.position.x > Player2.transform.position.x)
        {
            fDistanceX = Player1.transform.position.x - Player2.transform.position.x;
        }
        else
        {
            fDistanceX =  Player2.transform.position.x - Player1.transform.position.x;
        }

        // distance between players Y
        if (Player1.transform.position.y > Player2.transform.position.y)
        {
            fDistanceY = Player1.transform.position.y - Player2.transform.position.y;
        }
        else
        {
            fDistanceY = Player2.transform.position.y - Player1.transform.position.y;
        }

        positionToMoveTo = new Vector3((Player1.transform.position.x + Player2.transform.position.x) / 2 + 4, (Player1.transform.position.y + Player2.transform.position.y) / 2, -10);

        // use largest distace to scale screen
        if (fDistanceX > fDistanceY)
        {
            camSize = fSize + fDistanceX / fDivide;
        }
        else
        {
            camSize = fSize + fDistanceY / fDivide;
        }

        // get size differentce between current and desired  
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

        // get x distance from camera to destination 
        if (transform.position.x > positionToMoveTo.x)
        {
            fDistanceX = transform.position.x - positionToMoveTo.x;
        }
        else
        {
            fDistanceX = positionToMoveTo.x - transform.position.x;
        }

        // same for y
        if (transform.position.y > positionToMoveTo.y)
        {
            fDistanceY = transform.position.y - positionToMoveTo.y;
        }
        else
        {
            fDistanceY = positionToMoveTo.y - transform.position.y;
        }

        // change x move speed
        if (fDistanceX < fProximitySlowDown)
        {
            SpeedMultiplierX = fDistanceX / fProximityNumba2;
        }
        else
        {
            SpeedMultiplierX = 1.0f;
        }

        // same for y
        if (fDistanceY < 1000)
        {
            SpeedMultiplierY = fDistanceY / 400;
        }
        else
        {
            SpeedMultiplierY = 1.0f;
        }

        // change x camera position
        if (positionToMoveTo.x < cam.transform.position.x)
        {
            cam.transform.position = cam.transform.position - (transform.right * fCamSpeed * SpeedMultiplierX);
        }
        else if (positionToMoveTo.x > cam.transform.position.x)
        {
            cam.transform.position = cam.transform.position + (transform.right * fCamSpeed * SpeedMultiplierX);
        }

        // same for y
        if (positionToMoveTo.y < cam.transform.position.y)
        {
            cam.transform.position = cam.transform.position - (transform.up * fCamSpeed * SpeedMultiplierY);
        }
        else if (positionToMoveTo.y > cam.transform.position.y)
        {
            cam.transform.position = cam.transform.position + (transform.up * fCamSpeed * SpeedMultiplierY);
        }
    }
}
