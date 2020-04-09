using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class throwDummy : MonoBehaviour
{
    [Header("Pacifier & Aim")]
    public Rigidbody dummy;
    public GameObject cursor;
    public Transform throwPoint;
    [Space(5)]

    [Header("Line Segment for Aim")]
    public LayerMask layer;
    public LineRenderer line;
    public int lineSegment = 30;
    [Space(5)]

    private Camera Mcam;

    [Header("Fire Rate")]
    public float coolDownShot = 2;
    public float nextFire = 0;
      
    void Start()
    {
        Mcam = Camera.main;
        line.positionCount = lineSegment;
    }
    
    void Update()
    {
        DummyThrow();
    }

    void DummyThrow()
    {
        //Accessing the main camera
        Ray camRay = Mcam.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        //getting raycast position of where the player is aiming
        if (Physics.Raycast(camRay, out hit, 100f, layer))
        {
            cursor.SetActive(true);
            cursor.transform.position = hit.point + Vector3.up * 0.1f;

            Vector3 Velo = CalculateVelocity(hit.point, throwPoint.position, 1f);

            Visualize(Velo);

            transform.rotation = Quaternion.LookRotation(Velo);     //this line makes the pacifier sway or move

            //Left click spawns projectile at raycast position
            //Fire rate
            if (Time.time > nextFire)
            {
                if (Input.GetMouseButtonDown(0))
                {
                    soundManagerScript.PlaySound("click1"); //sound when input

                    Rigidbody pacifier = Instantiate(dummy, throwPoint.position, Quaternion.identity);
                    pacifier.velocity = Velo;
                    
                    nextFire = Time.time + coolDownShot; //Fire rate counter
                }                                   
            }   
        }
        else
        {
            cursor.SetActive(false);
        }
    }

    void Visualize(Vector3 vo) //This is for the trajectory linesegment visual
    {
        for (int i = 0; i < lineSegment; i++)
        {
            Vector3 pos = CalculatePosInTime(vo, i / (float)lineSegment);
            line.SetPosition(i, pos);
        }
    }

    //This calculates the arc projectile tragectory
    Vector3 CalculateVelocity(Vector3 target, Vector3 origin, float time)
    {

        Vector3 distance = target - origin;
        Vector3 distanceXZ = distance;
        distanceXZ.y = 0f;

        float Sy = distance.y;
        float Sxz = distanceXZ.magnitude;

        float Vy = Sy / time;
        float Vxz = Sxz / time + 0.7f * Mathf.Abs(Physics.gravity.y) * time;

        Vector3 result = distanceXZ.normalized;
        result *= Vxz;
        result.y = Vy;

        return result;

    }
    Vector3 CalculatePosInTime(Vector3 vo, float time)
    {
        Vector3 Vxz = vo;
        Vxz.y = 0f;

        Vector3 result = throwPoint.position + vo * time;
        float sY = (-0.5f * Mathf.Abs(Physics.gravity.y) * (time * time)) + (vo.y * time) + throwPoint.position.y;
        result.y = sY;
        return result;
    }

}
