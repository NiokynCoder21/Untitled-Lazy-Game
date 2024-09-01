using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Candy : MonoBehaviour
{
    public GameObject candy; //the key gameObject
    public KeyManager keyManager;
    public PlayerEnegy playerEnegy;
    public int energyBoost;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player")) //if collided game object has player tag
        {
            if (playerEnegy != null)
            {
                if (playerEnegy.currentEnergy < 200)
                {
                    playerEnegy.GainEnergy(energyBoost);
                    Destroy(candy);
                }
               
            }
        }
    }
}
