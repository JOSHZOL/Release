using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class PlayerController : MonoBehaviour {

    bool pressed;
    
    public int force;
    public bool bJumpReady = false;
    public string jumpButton;

    float fTimePassed;
    public bool bCanMove = true;

    public Slider power;
    public Rigidbody2D rb;

    // Use this for initialization
    void Start()
    {
        force = 100;
        pressed = false;
        bJumpReady = true;
    }

    public void vLolImGoingToMakeTheForceZeroSoDaNiggaDunRunOffDaFukinEdgeLolFukinBallDontKnowHowToStandStill()
    {
        rb.velocity = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.eulerAngles.z < 1.01f && transform.eulerAngles.z > -1.01)
        {

        }
        else
        {
            if (transform.eulerAngles.z > 360.0f || transform.eulerAngles.z < -360)
            {
                transform.Rotate(0, 0, 0);
            }

            if (transform.eulerAngles.z > 180.01f)
            {
                transform.Rotate(Vector3.forward * (100 * Time.deltaTime));
            }
            else if (transform.eulerAngles.z < 180.01f)
            {
                transform.Rotate(Vector3.back * (100 * Time.deltaTime));
            }
        } 

        fTimePassed += Time.deltaTime; 

        if (bJumpReady && bCanMove && rb != null)
        {
            if (Input.GetKeyDown(jumpButton))
            {
                pressed = true;
            }

            if (pressed && force <= 260)
            {
                force += 3;
            }

            if (Input.GetKeyUp(jumpButton))
            {
                //bJumpReady = false;
                //gameObject.transform.localScale = new Vector3(0.40f, 0.40f, 1.0f);
                //gameObject.GetComponent<CircleCollider2D>().radius = 4.0f;
                rb.AddForce(Vector3.right * force + Vector3.up * force);
                force = 100;
                pressed = false;
                bJumpReady = false;
            }

            power.value = force;
        }
    }
}


