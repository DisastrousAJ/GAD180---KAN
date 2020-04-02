using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestinationChange : MonoBehaviour
{
    public int xPos;
    public int zPos;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Agent1")
        {
            xPos = Random.Range(-8, 9);
            zPos = Random.Range(-1, -12);

            this.gameObject.transform.position = new Vector3(xPos, 5.6f, zPos);
        }

        if (other.tag == "Agent2")
        {
            xPos = Random.Range(-8, 9);
            zPos = Random.Range(-1, -12);

            this.gameObject.transform.position = new Vector3(xPos, 5.6f, zPos);
        }

        if (other.tag == "Agent3")
        {
            xPos = Random.Range(-8, 9);
            zPos = Random.Range(-1, -12);

            this.gameObject.transform.position = new Vector3(xPos, 5.6f, zPos);
        }
    }
}
