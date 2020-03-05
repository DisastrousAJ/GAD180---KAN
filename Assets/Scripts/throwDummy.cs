using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class throwDummy : MonoBehaviour
{
    public Rigidbody dummy;
    public GameObject cursor;
    public Transform throwPoint;
    public LayerMask layer;
    public LineRenderer line;
    public int lineSegment = 30;
    private Camera Mcam;

    public float coolDownShot = 2;
    public float nextFire = 0;

    // Start is called before the first frame update
    void Start()
    {
        Mcam = Camera.main;
        line.positionCount = lineSegment;
    }

    // Update is called once per frame
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

            transform.rotation = Quaternion.LookRotation(Velo);

            //Left click spawns projectile at raycast position
            //Fire rate
            if (Time.time > nextFire)
            {
                if (Input.GetMouseButtonDown(0))
                {
                    Rigidbody pacifier = Instantiate(dummy, throwPoint.position, Quaternion.identity);
                    pacifier.velocity = Velo;

                    nextFire = Time.time + coolDownShot;

                }
            }
            
        }
        else
        {
            cursor.SetActive(false);

        }

    }
    void Visualize(Vector3 vo)
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
