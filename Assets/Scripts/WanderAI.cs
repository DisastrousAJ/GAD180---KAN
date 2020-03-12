using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WanderAI : MonoBehaviour
{

    public float moveSpeed = 7f;
    public float rotSpeed = 300f;

    private bool isWandering = false;
    private bool isRotatingLeft = false;
    private bool isRotatingRight = false;
    private bool isWalking = false;

    void Update()
    {
        if (isWandering == false)
        {
            StartCoroutine(StartPulsing());
            StartCoroutine(Wander());
        }

        if (isRotatingRight == true)
        {
            transform.Rotate(transform.up * Time.deltaTime * rotSpeed);
        }

        if (isRotatingLeft == true)
        {
            transform.Rotate(transform.up * Time.deltaTime * -rotSpeed);
        }

        if (isWalking == true)
        {
            transform.position += transform.forward * moveSpeed * Time.deltaTime;
        }

    }

    //This is where random walking and turning taking place
    IEnumerator Wander()
    {
        int rotTime = Random.Range(1, 2);
        int rotateWait = Random.Range(1, 2);
        int rotateLorR = Random.Range(1, 2);
        int walkWait = Random.Range(1, 3);
        int walkTime = Random.Range(1, 3);

        isWandering = true;
        yield return new WaitForSeconds(walkWait);

        isWalking = true;
        yield return new WaitForSeconds(walkTime);

        isWalking = false;
        yield return new WaitForSeconds(rotateWait);


        if (rotateLorR == 1)
        {
            isRotatingRight = true;
            yield return new WaitForSeconds(rotTime);

            isRotatingRight = false;
        }

        if (rotateLorR == 2)
        {
            isRotatingLeft = true;
            yield return new WaitForSeconds(rotTime);

            isRotatingLeft = false;
        }

        isWandering = false;
    }

    //This is for the pusling effect of the cube
    private IEnumerator StartPulsing()
    {
        float rotateWait = Random.Range(0, 1f);
        yield return new WaitForSeconds(rotateWait);

        for (float i = 0f; i <= 1f; i += 0.1f)
        {
            transform.localScale = new Vector3(
                (Mathf.Lerp(transform.localScale.x, transform.localScale.x + 0.070f, Mathf.SmoothStep(0f, 1f, 1))),
                (Mathf.Lerp(transform.localScale.y, transform.localScale.y + 0.070f, Mathf.SmoothStep(0f, 1f, 1))),
                (Mathf.Lerp(transform.localScale.z, transform.localScale.z + 0.070f, Mathf.SmoothStep(0f, 1f, 1)))
                );
            yield return new WaitForSeconds(0.007f);
        }

        for (float i = 0f; i >= 1f; i += 0.1f)
        {
            transform.localScale = new Vector3(
                (Mathf.Lerp(transform.localScale.x, transform.localScale.x + 0.030f, Mathf.SmoothStep(0f, 1f, 1))),
                (Mathf.Lerp(transform.localScale.y, transform.localScale.y + 0.030f, Mathf.SmoothStep(0f, 1f, 1))),
                (Mathf.Lerp(transform.localScale.z, transform.localScale.z + 0.030f, Mathf.SmoothStep(0f, 1f, 1)))
                );
            yield return new WaitForSeconds(0.005f);
        }


        for (float i = 0f; i <= 1f; i += 0.1f)
        {
            transform.localScale = new Vector3(
                (Mathf.Lerp(transform.localScale.x, transform.localScale.x - 0.070f, Mathf.SmoothStep(0f, 1f, 1))),
                (Mathf.Lerp(transform.localScale.y, transform.localScale.y - 0.070f, Mathf.SmoothStep(0f, 1f, 1))),
                (Mathf.Lerp(transform.localScale.z, transform.localScale.z - 0.070f, Mathf.SmoothStep(0f, 1f, 1)))
                );
            yield return new WaitForSeconds(0.007f);
        }

        for (float i = 0f; i >= 1f; i += 0.1f)
        {
            transform.localScale = new Vector3(
                (Mathf.Lerp(transform.localScale.x, transform.localScale.x - 0.030f, Mathf.SmoothStep(0f, 1f, 1))),
                (Mathf.Lerp(transform.localScale.y, transform.localScale.y - 0.030f, Mathf.SmoothStep(0f, 1f, 1))),
                (Mathf.Lerp(transform.localScale.z, transform.localScale.z - 0.030f, Mathf.SmoothStep(0f, 1f, 1)))
                );
            yield return new WaitForSeconds(0.005f);
        }


    }

}