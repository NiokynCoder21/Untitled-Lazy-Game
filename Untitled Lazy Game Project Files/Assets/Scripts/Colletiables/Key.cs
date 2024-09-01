using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    public GameObject circle; //the key gameObject
    public KeyManager keyManager;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player")) //if collided game object has player tag
        {

            if (keyManager != null)
            {
                if (keyManager.currentAmount > 0)
                {
                    keyManager.LossKey(-1);
                    circle.gameObject.SetActive(false);
                }
            }
        }
    }
}
