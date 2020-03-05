using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyDummies : MonoBehaviour
{
    //this is to distroy the game object player

    //void OnTriggerEnter(Collider other)
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Floor")
        {
            Destroy(gameObject, 2f);
        }
        else if (other.gameObject.tag == "Baby")
        {
            Destroy(gameObject);
        }

    }
}
