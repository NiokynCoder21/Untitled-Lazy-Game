using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class PlayerEnegy : MonoBehaviour
{
    public float maxEnergy = 200; //max health in the game
    public float currentEnergy; //current health in the game
    public HealthBars healthBar; //reference to the healthBar game object
    public GameManager gameManager;
    public TMP_Text[] textObjects;

    void Start()
    {
        currentEnergy = maxEnergy; //set current health to max health
        healthBar.SetMaxHealth(maxEnergy); //set health bar to max health  

    }

    public void LossEnergy(float energy) //function for when the enemy takes health
    {
        currentEnergy -= energy; //this reduces damage from current health and assigns the current health
        healthBar.SetHealth(currentEnergy); //set healthbar to current health

        if (currentEnergy <= 0)
        {
            SceneManager.LoadScene("SampleScene", LoadSceneMode.Single); //load the game over screen
        }
    }

    public void GainEnergy(float energy)
    {
        currentEnergy += energy;
        healthBar.SetHealth(currentEnergy);
    }

    //Brakeys.(2020, Febuary 9). How to make a Health bar in Unity![Video] https://www.youtube.com/watch?v=BLfNP4Sc_iA&list=PLt1E2jJc5nDj6KQi6BVJElz3vqFmg-B8I&index=4 
}
