using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snake360 : MonoBehaviour
{

    private Rigidbody2D snake360RigidBody;
    private Vector2 startingVelocity;

    private void Awake()
    {
        snake360RigidBody = GetComponent<Rigidbody2D>();
        startingVelocity = new Vector2(1, 1);

    }

    private void Start()
    {
        snake360RigidBody.velocity = startingVelocity;
    }
    private void Update()
    {
        HandleInput();



    }

    

    private void HandleInput()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            snake360RigidBody.AddForce();

        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            snake360RigidBody.AddTorque(-2);
        }


    }

    private void HandleGridMovement()
    {
       

    }

}
