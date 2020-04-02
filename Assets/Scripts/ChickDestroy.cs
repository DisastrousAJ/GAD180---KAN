using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickDestroy : MonoBehaviour
{
    
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Agent1"))
        {
            ScoreScript.scoreValue += 1;
            other.gameObject.SetActive(true);
        }
  
        if (other.gameObject.CompareTag("Agent2"))
        {
            ScoreScript.scoreValue += 1;
            other.gameObject.SetActive(true);
        }
        
        if (other.gameObject.CompareTag("Agent3"))
        {
            ScoreScript.scoreValue += 1;
            other.gameObject.SetActive(true);
        }
        
    }
}
