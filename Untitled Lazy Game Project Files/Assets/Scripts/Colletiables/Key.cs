using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    public GameObject circle; //the key gameObject
    public KeyManager keyManager; //reference to the keymanager script

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player")) //if collided game object has player tag
        {

            if (keyManager != null) //if keymanager script does exist
            {
                if (keyManager.currentAmount > 0) //if the player has not found all the keys
                {
                    keyManager.LossKey(-1); //this calls the loss function once collision happens
                    circle.gameObject.SetActive(false); //this sets the object to false
                }
            }
        }
    }
}
