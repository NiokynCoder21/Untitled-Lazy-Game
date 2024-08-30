using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class KeyManager : MonoBehaviour
{
    public static KeyManager Instance;

    public int currentAmount;
    public int startAmount;
    public TMP_Text[] textObjects;
    public int currentIndex = 0;
    private TMP_Text lastEnabledText;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        currentAmount = startAmount;

        foreach (var textObject in textObjects)
        {
            textObject.gameObject.SetActive(false);
        }
    }

    public void LossKey(int loss)
    {
        if (currentAmount > 0 && currentIndex < textObjects.Length)
        {
            currentAmount += loss; //this adds health to the currenthealth and assigns the current health 

            if (lastEnabledText != null)
            {
                lastEnabledText.gameObject.SetActive(false);
            }

            lastEnabledText = textObjects[currentIndex];
            textObjects[currentIndex].gameObject.SetActive(true);
            currentIndex++;
        }
        
    }

}
