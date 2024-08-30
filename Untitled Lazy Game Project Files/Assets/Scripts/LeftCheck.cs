using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftCheck : MonoBehaviour
{
    public PlayerMovement playerMovement;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Wall")) //if the object does have wall tag, this to ensure it is not wall running
        {
            playerMovement.SetLeftWall(true); //this is set grounded to true meaning the player is grounded
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Wall")) //if the object does have wall tag, this to ensure it is not wall running
        {
            playerMovement.SetLeftWall(false); //this is set grounded to false meaning the player is grounded                                         
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Wall")) //if the object does have wall tag, this to ensure it is not wall running
        {
            playerMovement.SetLeftWall(true);  //this is set grounded to true meaning the player is grounded
        }
    }
}
