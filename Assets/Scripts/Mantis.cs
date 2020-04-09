using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mantis : MonoBehaviour
{
    //the main cause of this script is to repell destinationchange script defined game objects

    GameObject player;
    GameObject cot;
    GameObject chest;
    GameObject bookShelf;
    GameObject crib;

    void Start()
    {
        player = GameObject.Find("Player");
        cot = GameObject.Find("Cot");
        chest = GameObject.Find("Chest");
        bookShelf = GameObject.Find("BookShelf");
        crib = GameObject.Find("Crib");
    }
  
    void Update()
    {
        float distanceToPlayer = Vector3.Distance(this.transform.position, player.transform.position);

        if (distanceToPlayer < 2)
        {
            AvoidPlayer();
        }
       
        else
        {
            Idle();
        }

        float distanceToCot = Vector3.Distance(this.transform.position, cot.transform.position);

        if (distanceToCot < 2)
        {
            AvoidCot();
        }

        else
        {
            Idle();
        }

        float distanceToChest = Vector3.Distance(this.transform.position, chest.transform.position);

        if (distanceToChest < 2)
        {
            AvoidChest();
        }

        else
        {
            Idle();
        }

        float distanceToBookShelf = Vector3.Distance(this.transform.position, bookShelf.transform.position);

        if (distanceToBookShelf < 2)
        {
            AvoidBookShelf();
        }

        else
        {
            Idle();
        }

        float distanceToCrib = Vector3.Distance(this.transform.position, crib.transform.position);

        if (distanceToCrib < 2)
        {
            AvoidCrib();
        }

        else
        {
            Idle();
        }
    }

    void Idle()
    {

    }

    void AvoidPlayer()
    {
        this.transform.position = Vector3.MoveTowards(this.transform.position, player.transform.position, -0.01f);
    }

    void AvoidCot()
    {
        this.transform.position = Vector3.MoveTowards(this.transform.position, cot.transform.position, -0.01f);
    }

    void AvoidChest()
    {
        this.transform.position = Vector3.MoveTowards(this.transform.position, chest.transform.position, -0.01f);
    }

    void AvoidBookShelf()
    {
        this.transform.position = Vector3.MoveTowards(this.transform.position, bookShelf.transform.position, -0.01f);
    }

    void AvoidCrib()
    {
        this.transform.position = Vector3.MoveTowards(this.transform.position, crib.transform.position, -0.01f);
    }
}