using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundManagerScript : MonoBehaviour
{
    public static AudioClip timerSound;
    static AudioSource beep;
    void Start()
    {
        timerSound = Resources.Load<AudioClip>("Alarm");
        beep = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public static void PlaySound (string clip)
    {
        switch (clip)
        {
            case "Alarm":
                beep.PlayOneShot(timerSound);
                break;
        }
    }
}
