using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour
{
    public GameObject chest;

    // Start is called before the first frame update
    void Start()
    {
        chest = GameObject.Find("Chest");

    }

    // Update is called once per frame
    void Update()
    {
        float distanceToChest = Vector3.Distance(this.transform.position, chest.transform.position);



        if (distanceToChest < 5)
        {
            AvoidChest();
        }

        else
        {
            Idle();
        }
    }


    void Idle()
    {

    }

    void AvoidChest()
    {
        this.transform.position = Vector3.MoveTowards(this.transform.position, chest.transform.position, -0.02f);
    }
}
