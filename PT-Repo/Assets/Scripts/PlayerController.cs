using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float h_Input;
    private float v_Input;
    private float xRange = 7;
    private float zRange = 5;
    private float translateSpeed = 10;
    void Update()
    {
        //ABSTRACTION
        MoveCar();
    }
    private void MoveCar()
    {
        //moves the car horizontally
        h_Input = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * Time.deltaTime * h_Input * translateSpeed);
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        //moves the car vertically
        v_Input = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * Time.deltaTime * v_Input * translateSpeed/2);
        if (transform.position.z > zRange * 3)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zRange * 3);
        }
        if (transform.position.z < -zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -zRange);
        }
    }       
}
