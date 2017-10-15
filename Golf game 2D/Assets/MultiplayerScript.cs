using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MultiplayerScript : MonoBehaviour
{

    public Sprite Highlighted;
    public Sprite Unhighlighted;

    SpriteRenderer srSpriteRenderer;

    // Use this for initialization

    void Start()
    {
        srSpriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnMouseEnter()
    {
        srSpriteRenderer.sprite = Highlighted;
    }

    public void OnMouseExit()
    {
        srSpriteRenderer.sprite = Unhighlighted;
    }

    private void OnMouseDown()
    {
        SceneManager.LoadScene("GamePlay");
    }
}
