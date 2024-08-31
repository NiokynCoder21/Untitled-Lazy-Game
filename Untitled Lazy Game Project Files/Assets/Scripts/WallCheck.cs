using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallCheck : MonoBehaviour
{
    public PlayerMovement playerMovement; //reference to the playermovement script

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Wall")) //if the object does have wall tag
        {
            playerMovement.SetWalled(true); //this is set walled to true meaning the player is touching a wall
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Wall")) //if the object does have wall tag
        {
            playerMovement.SetWalled(false); //this is set walled to false meaning the player is not touching a wall                                       
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Wall")) //if the object does have wall tag
        {
            playerMovement.SetWalled(true);  //this is set walled to true meaning the player is touching a wall
        }
    }

}
