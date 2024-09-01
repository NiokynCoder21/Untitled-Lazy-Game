using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightCheck : MonoBehaviour
{
    public PlayerMovement playerMovement;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Wall")) //if collide with game object check if it has tag wall
        {
            playerMovement.SetRightWall(true); //this is set rightWall to true meaning the player is touching the right wall
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Wall")) //if collide with game object check if it has tag wall
        {
            playerMovement.SetRightWall(false); //this is set rightWall to false meaning the player is not touching the right wall                                       
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Wall")) //if collide with game object check if it has tag wall
        {
            playerMovement.SetRightWall(true);  //this is set rightWall to true meaning the player is touching the right wall    
        }
    }
}
