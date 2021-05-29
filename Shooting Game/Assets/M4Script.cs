using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class M4Script : MonoBehaviour
{

    public float range = 1000f;
    public GameObject bullet;
    // public Transform fire;
    void Update()
    {
        if (Input.GetButton("Fire1"))
        {

            RaycastHit hit;

            if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.left*20 ), out hit, range))
            {

                Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.left ), Color.red);
                Debug.DrawLine(transform.position, transform.TransformDirection(Vector3.left), Color.red, range);
               

            }

        }


    }


}
