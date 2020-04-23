using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestroyDummies : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        //this will destroy the pacifier when it hits the floor and will make a sound

        if (other.gameObject.tag == "Floor")
        {
            SoundManagerScript.PlaySound("ball");
            Destroy(gameObject, 0.5f);
        }

        //this is only for the sound when it hits game object

        if (other.gameObject.tag == "BookShelf")
        {
            SoundManagerScript.PlaySound("floor");
        }

        if (other.gameObject.tag == "Chest")
        {
            SoundManagerScript.PlaySound("floor");
        }

        if (other.gameObject.tag == "Cot")
        {
            SoundManagerScript.PlaySound("floor");
        }
    }
}
