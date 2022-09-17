using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody rb;

    public Vector3 rotationAngle;
    public float forwardForce = 2000f;
    public float sideForce = 500f;


    

    // Start is called before the first frame update
    void Start()
    {
         
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(forwardForce * Time.deltaTime, 0, 0);

        if (Input.GetKey("a"))
        {
            rb.AddForce(0, 0, sideForce * Time.deltaTime, ForceMode.VelocityChange);
            if(transform.localRotation.y > 0.260)
            {
                transform.rotation = Quaternion.Euler(-210, -180, 0);
            }
            transform.Rotate(-rotationAngle * Time.deltaTime);
        }
        if (Input.GetKey("d"))
        {
            rb.AddForce(0, 0, -sideForce * Time.deltaTime, ForceMode.VelocityChange);
            if (transform.localRotation.y < -0.260)
            {
                transform.rotation = Quaternion.Euler(-150, -180, 0);
            }
            transform.Rotate(rotationAngle * Time.deltaTime);
        }

        //Debug.Log(transform.localRotation);
    }
}
