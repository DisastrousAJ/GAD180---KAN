using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickDestroy : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Agent1"))
        {
            SoundManagerScript.PlaySound("click2"); //for the sound
            ScoreScript.scoreValue += 1; //for the score
            other.gameObject.SetActive(true); //for the collision
        }
  
        if (other.gameObject.CompareTag("Agent2"))
        {
            SoundManagerScript.PlaySound("click2");
            ScoreScript.scoreValue += 1;
            other.gameObject.SetActive(true);
        }
        
        if (other.gameObject.CompareTag("Agent3"))
        {
            SoundManagerScript.PlaySound("click2");
            ScoreScript.scoreValue += 1;
            other.gameObject.SetActive(true);
        }
        
    }
}
