using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NocutMusic : MonoBehaviour
{
    void Awake()
    {
        //thi will not cut background music when clicking to next scene
        DontDestroyOnLoad(transform.gameObject);
    }
}
