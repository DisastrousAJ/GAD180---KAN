﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class destroyDummies : MonoBehaviour
{
    public int score;
    public Text scoreText;

    void Start()
    {
        score = 0;
        SetScoreText();
        GameObject.Find("ScoreManager");
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Baby"))
        {
            other.gameObject.SetActive(false);
            score = score + 1;
            SetScoreText();
        }
    }

    void SetScoreText()
    {
        scoreText.text = "Score: " + score.ToString();
    }
    //this is to distroy the game object player

    //void OnTriggerEnter(Collider other)



    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Floor")
        {
            Destroy(gameObject, 1f);
        }
        else if (other.gameObject.tag == "Baby")
        {
            Destroy(gameObject);
            score = score + 1;
            SetScoreText();
            scoreText.text = "Score: " + score.ToString();
        }

    }
}
