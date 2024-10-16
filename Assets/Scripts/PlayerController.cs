using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float rotateSpeed = 5f;
    [SerializeField] float boost = 20f;
    [SerializeField] float baseSpeed = 10f;
    Rigidbody2D rb2d;
    SurfaceEffector2D surfaceEffector2D;
    bool canMove = true;
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        surfaceEffector2D = FindObjectOfType<SurfaceEffector2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(canMove)
        {
            RotatePlayer();
            RespondToBoost();
        }
        
    }
    public void OnDisable() {
        canMove = false;
    }

    private void RespondToBoost()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            surfaceEffector2D.speed = boost;
        }
        else
        {
            surfaceEffector2D.speed = baseSpeed;
        }
    }

    private void RotatePlayer()
    {
        if (Input.GetKey(KeyCode.D))
        {
            rb2d.AddTorque(rotateSpeed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb2d.AddTorque(-rotateSpeed);
        }
    }
}
