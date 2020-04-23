using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndScoreScript : MonoBehaviour
{
    public static int tempscoreValue= 0;
    Text score;

    void Start()
    {
        tempscoreValue = ScoreScript.scoreValue;
        score = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
        score.text = "" + tempscoreValue;
    }
}