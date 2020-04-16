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

    void OnTriggerEnter(Collider col)
    {
       // if ()
       // {
            col.transform.position = new Vector3(Random.Range(-13.0f, 15.0f), col.transform.position.y, Random.Range(-14.0f, 12.0f));
       // }
       // else if ()
       // {

        //}
    }    
}
