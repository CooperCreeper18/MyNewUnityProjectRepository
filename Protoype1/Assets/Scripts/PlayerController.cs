using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*
 * Cooper Denault
 * Assignment 2 Prototype 
 * Allows the user input to controller the player
 */

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float turnSpeed;

    public float horizontalInput;
    public float forwardInput;


    // Update is called once per frame
    void Update()
    {
        forwardInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");


        //Move Forward with forward input
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);

        transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime * horizontalInput);
    }
}
