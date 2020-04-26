using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestinationChange : MonoBehaviour
{
    //this script is to randomly guide agents to next destination uppon colliding to game object specified

    public int xPos;
    public int zPos;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Agent1")
        {
            xPos = Random.Range(-7, 7);
            zPos = Random.Range(-1, -14);

            this.gameObject.transform.position = new Vector3(xPos, 5.9f, zPos);
        }

        if (other.tag == "Agent2")
        {
            xPos = Random.Range(-7, 7);
            zPos = Random.Range(-1, -14);

            this.gameObject.transform.position = new Vector3(xPos, 5.9f, zPos);
        }

        if (other.tag == "Agent3")
        {
            xPos = Random.Range(-7, 7);
            zPos = Random.Range(-1, -14);

            this.gameObject.transform.position = new Vector3(xPos, 5.9f, zPos);
        }
    }
}