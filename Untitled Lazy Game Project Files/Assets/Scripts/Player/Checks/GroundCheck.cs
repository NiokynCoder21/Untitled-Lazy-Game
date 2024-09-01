using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    public PlayerMovement playerMovement; //reference to the player controller

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Platform")) //if the object does have wall tag, this to ensure it is not wall running
        {
            playerMovement.SetGrounded(true); //this is set grounded to true meaning the player is grounded
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Platform")) //if the object does have wall tag, this to ensure it is not wall running
        {
            playerMovement.SetGrounded(false); //this is set grounded to false meaning the player is grounded                                         
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Platform")) //if the object does have wall tag, this to ensure it is not wall running
        {
            playerMovement.SetGrounded(true);  //this is set grounded to true meaning the player is grounded
        }
    }

    //Potato Code. (2022, May 15). How to Make a Rigidbody Player Controller with Unity's Input System.[Video] Youtube. https://www.youtube.com/watch?v=1LtePgzeqjQ
}
