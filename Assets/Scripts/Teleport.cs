using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
 

    void OnTriggerEnter(Collider col)
    {
        col.transform.position = new Vector3(Random.Range(11.0f, -13.0f), col.transform.position.y, Random.Range(18.0f, -15.0f));
    }
}
