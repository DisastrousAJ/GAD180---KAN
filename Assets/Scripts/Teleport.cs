using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    void OnTriggerEnter(Collider col)
    {
        col.transform.position = new Vector3(Random.Range(-13.0f, 15.0f), col.transform.position.y, Random.Range(-14.0f, 12.0f));  
    }    
}
