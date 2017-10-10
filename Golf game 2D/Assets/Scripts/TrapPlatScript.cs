using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapPlatScript : MonoBehaviour {

    float fTimePassed;
    bool isTrue = false;
    public float fTimeDrop;
    public float fTimeRespawn;
    public GameObject goTrapPlat;
    public BoxCollider2D daBox;
    public Sprite platLight;
    public Sprite platDark;

    public GameObject particles;
    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        if (isTrue)
        {
            fTimePassed += Time.deltaTime;
        }
        if (fTimePassed >= fTimeDrop)
        {
            // GameObject.Find("bc_floating2").GetComponent<BoxCollider2D>().enabled = false;
            daBox.enabled = false;
            goTrapPlat.GetComponent<SpriteRenderer>().sprite = platDark;
        }
        if (fTimePassed >= fTimeDrop + fTimeRespawn)
        {
            particles.SetActive(false);
            daBox.enabled = true;
            isTrue = false;
            fTimePassed = 0.0f;
            goTrapPlat.GetComponent<BoxCollider2D>().enabled = true;
            goTrapPlat.GetComponent<SpriteRenderer>().sprite = platLight;
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        isTrue = true;
        particles.SetActive(true);
    }
}
