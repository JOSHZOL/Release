using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowScoreScript : MonoBehaviour {

    public Sprite zero;
    public Sprite one;
    public Sprite two;
    public Sprite three;

    public GameObject BlueScore;
    public GameObject CremeScore;


    // Use this for initialization
    void Start () {
        Debug.Log(ScoreScript.iCremeScore);

        if (ScoreScript.iBlueScore == 0)
        {
            BlueScore.GetComponent<SpriteRenderer>().sprite = zero;
        }
        else if (ScoreScript.iBlueScore == 1)
        {
            BlueScore.GetComponent<SpriteRenderer>().sprite = one;
        }
        else if (ScoreScript.iBlueScore == 2)
        {
            BlueScore.GetComponent<SpriteRenderer>().sprite = two;
        }
        else if (ScoreScript.iBlueScore == 3)
        {
            BlueScore.GetComponent<SpriteRenderer>().sprite = three;
        }

        if (ScoreScript.iCremeScore == 0)
        {
            CremeScore.GetComponent<SpriteRenderer>().sprite = zero;
        }
        else if (ScoreScript.iCremeScore == 1)
        {
            CremeScore.GetComponent<SpriteRenderer>().sprite = one;
        }
        else if (ScoreScript.iCremeScore == 2)
        {
            CremeScore.GetComponent<SpriteRenderer>().sprite = two;
        }
        else if (ScoreScript.iCremeScore == 3)
        {
            CremeScore.GetComponent<SpriteRenderer>().sprite = three;
        }

        ScoreScript.iBlueScore = 0;
        ScoreScript.iCremeScore = 0;
    }
	
	// Update is called once per frame
	void Update () {
        
    }

    void vGetScores()
    {

    }
}
