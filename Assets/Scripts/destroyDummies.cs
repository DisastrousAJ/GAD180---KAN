using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class destroyDummies : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        //this will destroy the pacifier when it hits the floor and will make a sound

        if (other.gameObject.tag == "Floor")
        {
            soundManagerScript.PlaySound("ball");
            Destroy(gameObject, 0.5f);
        }

        //this is only for the sound when it hits game object

        if (other.gameObject.tag == "BookShelf")
        {
            soundManagerScript.PlaySound("floor");
        }

        if (other.gameObject.tag == "Chest")
        {
            soundManagerScript.PlaySound("floor");
        }

        if (other.gameObject.tag == "Cot")
        {
            soundManagerScript.PlaySound("floor");
        }
    }
}
