using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb; //the rigidbody attached to the player
    public bool isGrounded = true; //check if player is grounded
    public bool isWalled = false; //checks if the player is in contact with a wall

    public bool isWallLeft = false; //checks if the player is in contact with the left wall
    public bool isWallRight = false; //checks if the player is in contact with the right wall

    public Transform orientation; //check the direction the player is facing
    public float moveForce; //move the player to the right in air and ground
    public float upForce; //move the player to the left in air and ground
    public float sideForce; //this is how side ways is aplied to simulate wall jumping
    public float sideUPForce; //this is how up force is aplied to simulate wall jumping

    public PlayerEnegy playerEnegy;
    public float wallEnergy;

    void Update()
    {
        if (Input.GetKey("a")) //when the player presses a
        {
            rb.AddForce(-orientation.right * moveForce, ForceMode2D.Force); //add force to the left to allow the player to move to the left
        }

        if (Input.GetKey("d")) //when the player presses d
        {
            rb.AddForce(orientation.right * moveForce, ForceMode2D.Force); //add force to the right to allow the player to move to the right
        }

        if (Input.GetKeyDown(KeyCode.Space)) //when the player presses the space key
        {
            if (isGrounded == true) //if the player is on the ground
            {
                Jump(); //call the jump function
            }
            
            if(isWalled == true) //if the player is touching a wall
            {
                WallJump(); //call the wall jump function

                if (playerEnegy != null)
                {
                    playerEnegy.LossEnergy(wallEnergy);
                }
                
            }
        }

    }

    void Jump()
    {
        rb.AddForce(orientation.up * upForce, ForceMode2D.Impulse); //this adds upword force 
    }

    void WallJump()
    {
        if (isWallLeft == true) //if the player is touching the left wall
        {
            rb.AddForce(orientation.right * sideForce, ForceMode2D.Impulse); //this adds sideforce to the ride of the player
            rb.AddForce(orientation.up * sideUPForce, ForceMode2D.Impulse); //this adds upward force to the player
        }

        if(isWallRight == true) //if the player is touching the right wall
        {
            rb.AddForce(-orientation.right * sideForce, ForceMode2D.Impulse); //this adds sideforce to the ride of the player
            rb.AddForce(orientation.up * sideUPForce, ForceMode2D.Impulse); //this adds upward force to the player
        }
    }

    public void SetGrounded(bool state) //this is used to allow me to check for grounded in a collsion script
    {
        isGrounded = state;
    }

    public void SetWalled(bool state) //this is used to allow me to check for walled in a collsion script
    {
        isWalled = state;
    }

    public void SetLeftWall(bool state) //this is used to allow me to check for leftwall in a collsion script
    {
        isWallLeft = state;
    }

    public void SetRightWall(bool state) //this is used to allow me to check for rightwall in a collsion script
    {
        isWallRight = state;
    }

}
