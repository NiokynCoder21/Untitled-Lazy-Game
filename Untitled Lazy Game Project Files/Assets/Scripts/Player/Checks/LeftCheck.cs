using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftCheck : MonoBehaviour
{
    public PlayerMovement playerMovement; //reference to the playermovement script

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Wall")) //if the object does have wall tag
        {
            playerMovement.SetLeftWall(true); //this is set leftWall to true meaning the player is tocuhing the left wall    
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Wall")) //if the object does have wall tag
        {
            playerMovement.SetLeftWall(false); //this is set leftWall to false meaning the player is not tocuhing the left wall                                         
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Wall")) //if the object does have wall tag
        {
            playerMovement.SetLeftWall(true);  //this is set leftWall to true meaning the player is tocuhing the left wall   
        }
    }
}
