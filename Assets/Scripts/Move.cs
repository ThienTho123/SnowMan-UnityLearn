using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float torqueAmount = 1f;
    [SerializeField] float bootsSpeed = 30f;
    [SerializeField] float baseSpeed = 20f;
    bool canMove = true;

    Rigidbody2D r2b2;
    SurfaceEffector2D surfaceEffector2D;
    void Start()
    {
        r2b2 = GetComponent<Rigidbody2D>();
        surfaceEffector2D = FindObjectOfType<SurfaceEffector2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(canMove)
        RotatePlayer();
        RespondToBoots();

    }
    public void DisableControl()
    {
        canMove= false;
    }

    private void RespondToBoots()
    {
        if(Input.GetKey(KeyCode.W))
        {
            surfaceEffector2D.speed = bootsSpeed;
        }
        if(Input.GetKey(KeyCode.S))
        {
            surfaceEffector2D.speed = baseSpeed;
        }
    }

    void RotatePlayer()
    {
        if (Input.GetKey(KeyCode.D))
        {
            r2b2.AddTorque(-torqueAmount);
        }
        if (Input.GetKey(KeyCode.A))
        {
            r2b2.AddTorque(torqueAmount);
        }
    }

    void OnTriggerEnter2D(Collider2D other) 
    {
            if(other.tag == "Finish")
            {
                r2b2.AddTorque(0);
            }
    }
    
}
