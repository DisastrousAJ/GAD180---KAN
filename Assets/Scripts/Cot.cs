using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cot : MonoBehaviour
{
    public GameObject cot;

    // Start is called before the first frame update
    void Start()
    {
        cot = GameObject.Find("Cot");

    }

    // Update is called once per frame
    void Update()
    {
        float distanceToCot = Vector3.Distance(this.transform.position, cot.transform.position);



        if (distanceToCot < 5)
        {
            AvoidCot();
        }

        else
        {
            Idle();
        }
    }


    void Idle()
    {

    }

    void AvoidCot()
    {
        this.transform.position = Vector3.MoveTowards(this.transform.position, cot.transform.position, -0.02f);
    }
}
