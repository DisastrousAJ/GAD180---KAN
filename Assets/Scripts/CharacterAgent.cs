using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CharacterAgent : MonoBehaviour
{
    //this si the controll for navMesh
    
    public GameObject charachterDestination;
    NavMeshAgent theAgent;
   
    void Start()
    {
        theAgent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        theAgent.SetDestination(charachterDestination.transform.position);
    }
}
