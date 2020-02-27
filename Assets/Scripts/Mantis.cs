using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mantis : MonoBehaviour
{
    //int behaviour = 0;
    //0 = idle
    //1 = seek food
    //2 = avoid predator

    public GameObject player;
    



    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        //
    }

    // Update is called once per frame
    void Update()
    {
        float distanceToPlayer = Vector3.Distance(this.transform.position, player.transform.position);
        //float distanceToFood = Vector3.Distance(this.transform.position, food.transform.position);


        if (distanceToPlayer < 10)
        {
            AvoidPlayer();
        }
       // else if (distanceToFood < 10)
       // {
        //    HuntFood();
       // }
        else
        {
            Idle();
        }
    }

    //void HuntFood()
   // {
   //     this.transform.position = Vector3.MoveTowards(this.transform.position, food.transform.position, 0.02f);
   // }

    void Idle()
    {

    }

    void AvoidPlayer()
    {
        this.transform.position = Vector3.MoveTowards(this.transform.position, player.transform.position, -0.02f);
    }

}