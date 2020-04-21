using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision other)
    {
       if (other.gameObject.tag == "Chest")
        {
            other.transform.position = new Vector3(Random.Range(-13.0f, 15.0f), other.transform.position.y, Random.Range(-14.0f, 12.0f));
        }
    }    
}
