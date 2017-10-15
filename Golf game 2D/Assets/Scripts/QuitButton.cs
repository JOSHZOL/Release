using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitButton : MonoBehaviour {

    public Sprite Highlighted;
    public Sprite Unhighlighted;

    SpriteRenderer spSpriteRenderer;

	// Use this for initialization
	void Start () {
        spSpriteRenderer = GetComponent<SpriteRenderer>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnMouseEnter()
    {
        spSpriteRenderer.sprite = Highlighted;
    }

    private void OnMouseExit()
    {
        spSpriteRenderer.sprite = Unhighlighted;
    }

    private void OnMouseDown()
    {
        Application.Quit();
    }
}
