using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb; //the rigidbody attached to the player
    public bool isGrounded = true; //check if player is grounded
    public bool isWalled = false;

    public bool isWallLeft = false;
    public bool isWallRight = false;

    public Transform orientation; //check the direction the player is facing
    public float moveForce; //move the player to the right in air and ground
    public float upForce; //move the player to the left in air and ground
    public float sideForce;

    public SpriteRenderer spriteRenderer;

    void Update()
    {
        if (Input.GetKey("a")) //when the player presses A
        {
            rb.AddForce(-orientation.right * moveForce, ForceMode2D.Force); //add force to the left to allow the player to move to the left
            spriteRenderer.flipX = true;
        }

        if (Input.GetKey("d")) //when the player presses B
        {
            rb.AddForce(orientation.right * moveForce, ForceMode2D.Force); //add force to the right to allow the player to move to the right
            spriteRenderer.flipX = false;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isGrounded == true)
            {
                Jump();
            }
            
            if(isWalled == true)
            {
                WallJump();
            }
        }

    }

    void Jump()
    {
        rb.AddForce(orientation.up * upForce, ForceMode2D.Impulse);
    }

    void WallJump()
    {
        if (isWallLeft == true)
        {
            rb.AddForce(-orientation.right * sideForce, ForceMode2D.Impulse);
        }

        if(isWallRight == true)
        {
            rb.AddForce(orientation.right * sideForce, ForceMode2D.Impulse);
        }
    }

    public void SetGrounded(bool state) //this is used to allow me to check for grounded in a collsion script
    {
        isGrounded = state;
    }

    public void SetWalled(bool state)
    {
        isWalled = state;
    }

    public void SetLeftWall(bool state)
    {
        isWallLeft = state;
    }

    public void SetRightWall(bool state)
    {
        isWallRight = state;
    }

}
