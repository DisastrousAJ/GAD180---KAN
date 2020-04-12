using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvoidObjects : MonoBehaviour
{

    int behaviour = 0;

    GameObject crib;
    GameObject bookShelf;
    GameObject cot;

    GameObject food1;
    GameObject food2;
    GameObject food3;


    void Start()
    {
        crib = GameObject.Find("Crib");
        bookShelf = GameObject.Find("BookShelf");
        cot = GameObject.Find("Cot");

        food1 = GameObject.Find("Agent1");
        food2 = GameObject.Find("Agent2");
        food3 = GameObject.Find("Agent3");
    }
    void Update()
    {
        switch (behaviour)
        {
            case 0:
                AvoidObject();
                break;

            case 1:
                HuntFood();
                break;
        }
    }

    void AvoidObject()
    {
        this.transform.position = Vector3.MoveTowards(this.transform.position, crib.transform.position, -0.02f);
        float distanceToCrib = Vector3.Distance(this.transform.position, crib.transform.position);

        this.transform.position = Vector3.MoveTowards(this.transform.position, bookShelf.transform.position, -0.02f);
        float distanceToBook = Vector3.Distance(this.transform.position, bookShelf.transform.position);

        this.transform.position = Vector3.MoveTowards(this.transform.position, cot.transform.position, -0.02f);
        float distanceToCot = Vector3.Distance(this.transform.position, cot.transform.position);

        float distanceToFood1 = Vector3.Distance(this.transform.position, food1.transform.position);
        float distanceToFood2 = Vector3.Distance(this.transform.position, food2.transform.position);
        float distanceToFood3 = Vector3.Distance(this.transform.position, food3.transform.position);

        if (distanceToCrib < 2)
        {
            behaviour = 0;
        }
        if (distanceToBook < 2)
        {
            behaviour = 0;
        }
        if (distanceToCot < 2)
        {
            behaviour = 0;
        }


        if (distanceToFood1 < 15)
        {
            behaviour = 1;
        }
        if (distanceToFood2 < 15)
        {
            behaviour = 1;
        }
        if (distanceToFood3 < 15)
        {
            behaviour = 1;
        }
    }

    void HuntFood()
    {
        float distanceToCrib = Vector3.Distance(this.transform.position, crib.transform.position);
        float distanceToBook = Vector3.Distance(this.transform.position, bookShelf.transform.position);
        float distanceToCot = Vector3.Distance(this.transform.position, cot.transform.position);

        this.transform.position = Vector3.MoveTowards(this.transform.position, food1.transform.position, 0.003f);
        this.transform.position = Vector3.MoveTowards(this.transform.position, food2.transform.position, 0.003f);
        this.transform.position = Vector3.MoveTowards(this.transform.position, food3.transform.position, 0.003f);

        if (distanceToCrib < 2)
        {
            behaviour = 0;
        }

        if (distanceToBook < 2)
        {
            behaviour = 0;
        }

        if (distanceToCot < 2)
        {
            behaviour = 0;
        }
    }

}
