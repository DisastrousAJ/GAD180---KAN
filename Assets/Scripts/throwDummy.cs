using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class throwDummy : MonoBehaviour
{
    [Header("The Pacifier Speed")]
    public float dummyForce = 40f;
    public GameObject dummyPrefab;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            DummyThrow();
        }
    }
    void DummyThrow()
    {
        GameObject dummy = Instantiate(dummyPrefab, transform.position, transform.rotation);
        Rigidbody rb = dummy.GetComponent<Rigidbody>();
        rb.AddForce(transform.forward * dummyForce, ForceMode.VelocityChange);
    }
}
