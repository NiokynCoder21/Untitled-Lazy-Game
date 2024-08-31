using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    public GameObject circle; //the key gameObject

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player")) //if collided game object has player tag
        {
            if (KeyManager.Instance.currentAmount > 0) //if the player has more than zero keys
            {
                KeyManager.Instance.LossKey(-1); //this reduces the counter , everytime the player picks up a key
                circle.gameObject.SetActive(false);
            }
        }
    }
}
