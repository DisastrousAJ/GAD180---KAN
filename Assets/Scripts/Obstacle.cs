using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    //int behaviour = 0;
    //0 = idle
    //1 = seek food
    //2 = avoid predator

    public GameObject obstacle;





    // Start is called before the first frame update
    void Start()
    {
        obstacle = GameObject.Find("Obstacle");
        //
    }

    // Update is called once per frame
    void Update()
    {
        float distanceToObstacle = Vector3.Distance(this.transform.position, obstacle.transform.position);
        //float distanceToFood = Vector3.Distance(this.transform.position, food.transform.position);


        if (distanceToObstacle < 3)
        {
            AvoidObstacle();
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

    void AvoidObstacle()
    {
        this.transform.position = Vector3.MoveTowards(this.transform.position, obstacle.transform.position, -0.02f);
    }

}