using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SettingsButton : MonoBehaviour {

    SpriteRenderer srSpriteRenderer;

    public Sprite Highlighted;
    public Sprite Unhighlighted;

    // Use this for initialization
    void Start () {
        srSpriteRenderer = GetComponent<SpriteRenderer>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnMouseEnter()
    {
        srSpriteRenderer.sprite = Highlighted;
    }

    private void OnMouseExit()
    {
        srSpriteRenderer.sprite = Unhighlighted;
    }

    private void OnMouseDown()
    {
        SceneManager.LoadScene("Settings");
    }
}
