using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb; //the rigidbody attached to the player
    public bool isGrounded = true; //check if player is grounded
    public Transform orientation; //check the direction the player is facing
    public float rightForce; //move the player to the right in air and ground
    public float leftForce; //move the player to the left in air and ground


    void Update()
    {
        if (Input.GetKey("a")) //when the player presses A
        {
            rb.AddForce(-orientation.right * rightForce, ForceMode2D.Force); //add force to the left to allow the player to move to the left
            transform.eulerAngles = new Vector3(0, 180, 0); //rotates the player 180 on the z - this flips the sprite
        }

        else if (Input.GetKey("d")) //when the player presses B
        {
            rb.AddForce(orientation.right * leftForce, ForceMode2D.Force); //add force to the right to allow the player to move to the right
            transform.eulerAngles = new Vector3(0, 0, 0f); //rotates the player 0 on x,y,z - this flips the sprite
        }

    }

    private void Start()
    {
      
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Platform")) //if player collides with game object with tag platform
        {
            isGrounded = true; //the player can jump
        }
    }

   
}
