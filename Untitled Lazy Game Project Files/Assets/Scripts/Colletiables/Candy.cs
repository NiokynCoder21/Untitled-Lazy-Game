using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Candy : MonoBehaviour
{
    public GameObject candy; //the key gameObject
    public PlayerEnegy playerEnegy; //the player energy script
    public int energyBoost; //how much energy the player gets from candy

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player")) //if collided game object has player tag
        {
            if (playerEnegy != null) //if playerEnergy script does exist
            {
                if (playerEnegy.currentEnergy < 200) //if the current energy is less than 200
                {
                   playerEnegy.GainEnergy(energyBoost); //call the gain energy script 
                   Destroy(candy); //destroy this game object
                }
               
            }
        }
    }
}
