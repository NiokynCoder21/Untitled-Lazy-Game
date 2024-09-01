using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMusicManager : MonoBehaviour
{
    public static MainMusicManager Instance; 

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this; //sets the current instance class to the static class variable
            DontDestroyOnLoad(gameObject); //this ensures the gameobject persists arcoss scences
        }
        else
        {
            Destroy(gameObject); //if another instance exists then destroy this game object
        }
    }

}
