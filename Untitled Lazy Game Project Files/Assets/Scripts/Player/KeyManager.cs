using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class KeyManager : MonoBehaviour
{
    public int currentAmount; //this is the currernt amount of keys the player has not found
    public int startAmount; //this is the amount of keys the player can find
    public TMP_Text[] textObjects; //this is an arrary that stores text for each key number text
    public int currentIndex = 0; 
    private TMP_Text lastEnabledText; //this is to see what is the current text object

    private void Start()
    {
        currentAmount = startAmount; //set the currerent amount to the start amount
        IntilizeTextObjects();
    }

    public void IntilizeTextObjects() //this loops through the array to ensure that all the text is disabled on start
    {
        if (textObjects != null)
        {
            foreach (var textObject in textObjects) //this goes through each textObject in the array text object
            {
                textObject.gameObject.SetActive(false); //this sets the text object to false
            }
        }
    }

    public void LossKey(int loss)
    {
        if (currentAmount > 0 && currentIndex < textObjects.Length) //if there keys to be found and this is to avoid getting textobjects not in bounds
        {
            currentAmount += loss; //this minuses the loss to the currentAmount and assigns the currentAmount 

            if (lastEnabledText != null)
            {
                lastEnabledText.gameObject.SetActive(false); //set the game object to false 
            }

            lastEnabledText = textObjects[currentIndex]; //this sets the latest text gameobject to lastEnabled text

            if (textObjects[currentIndex] != null)
            {
                textObjects[currentIndex].gameObject.SetActive(true); //set game object to true
                currentIndex++; //this moves the current index to the next text object
            }
           
            
        }
        
    }

}
