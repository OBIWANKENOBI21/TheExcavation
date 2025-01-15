using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;


[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D physicsbody = null;
    public float speed = 4f;
    // jump speed setting, in meters/second
    public float jumpSpeed = 6f;
    public Collider2D groundSensor = null;
    public LayerMask groundLayer = 0;

    // Awake is called before start
    private void Awake()
    {
        physicsbody = GetComponent<Rigidbody2D>();
    }

    public void FixedUpdate()
    {
        Vector2 newVelocity = physicsbody.velocity;
        newVelocity.x = speed * myJoystick.Horizontal;
        newVelocity.y = speed * myJoystick.Vertical;
        physicsbody.velocity = newVelocity;

    }

    


    public void MoveLeft()
    {
        // physicsbody.velocity.x = -1;

        // male a variable to hold the velocity
        // get the velocity from the rigidbody2D
        Vector2 newVelocity = physicsbody.velocity;

        newVelocity.x = -2.5f;

        physicsbody.velocity = newVelocity;

    }
    public void MoveRight()
    {
        // physicsbody.velocity.x = -1;

        // male a variable to hold the velocity
        // get the velocity from the rigidbody2D
        Vector2 newVelocity = physicsbody.velocity;

        newVelocity.x = 2.5f;

        physicsbody.velocity = newVelocity;

    }
    public void Jump()
    {
        // input to allow groundSensor's to work
        if (groundSensor.IsTouchingLayers(groundLayer))
        {
            // a varible to hold the velocity and physics component
            Vector2 newVelocity = physicsbody.velocity;

            // setting the velcity to move in postive y (UP) direction
            newVelocity.y = jumpSpeed;

            // update for the physics component's velocity to the changed value
            physicsbody.velocity = newVelocity;
        }
    }
    public Joystick myJoystick = null;


   



}
