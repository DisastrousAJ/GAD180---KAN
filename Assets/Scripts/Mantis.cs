using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mantis : MonoBehaviour
{
    public GameObject player;
    public GameObject cot;
    public GameObject chest;
    public GameObject bookShelf;

    void Start()
    {
        player = GameObject.Find("Player");
        cot = GameObject.Find("Cot");
        chest = GameObject.Find("Chest");
        bookShelf = GameObject.Find("BookShelf");
    }
  
    void Update()
    {
        float distanceToPlayer = Vector3.Distance(this.transform.position, player.transform.position);
        //float distanceToFood = Vector3.Distance(this.transform.position, food.transform.position);

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

    

}