using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookShelf : MonoBehaviour
{
    public GameObject bookShelf;
          
    // Start is called before the first frame update
    void Start()
    {
        bookShelf = GameObject.Find("BookShelf");
        
    }

    // Update is called once per frame
    void Update()
    {
        float distanceToBookShelf = Vector3.Distance(this.transform.position, bookShelf.transform.position);
    


        if (distanceToBookShelf < 5)
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

    void AvoidBookShelf()
    {
        this.transform.position = Vector3.MoveTowards(this.transform.position, bookShelf.transform.position, -0.02f);
    }
}
