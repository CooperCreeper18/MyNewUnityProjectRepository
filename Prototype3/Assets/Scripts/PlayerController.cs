﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    public float fumpForce;
    public ForceMode forceMode;
    public float gravityModifier;

    public bool isOnGround = false;
    public bool gameOver = false;


    // Start is called before the first frame update
    void Start()
    {
        //set a reference to our figidbosy comonent
        rb = GetComponent<Rigidbody>();

        forceMode = ForceMode.Impulse;

        //modify gravity
        if (Physics.gravity.y > -10)
        {
            Physics.gravity *= gravityModifier;
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround && !gameOver)
        {
            rb.AddForce(Vector3.up * fumpForce, forceMode);
            isOnGround = false;
        }
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
        }
        else if (collision.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log("Game Over!");
            gameOver = true;
        }
    }




}
