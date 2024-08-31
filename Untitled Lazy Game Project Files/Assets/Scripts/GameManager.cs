using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private const string PlayerDeathSceneKey = "PlayerDeathScene"; //this is used to store data when the player dies 

    public void PlayerDied(string sceneName) //when player dies this 
    {
        PlayerPrefs.SetString(PlayerDeathSceneKey, sceneName); //when the player dies it saves the scence they died in
    }

    public void RespawnPlayer() //avalible scences that can be used for respawn
    {
        string lastDeathScene = PlayerPrefs.GetString(PlayerDeathSceneKey, "SampleScene"); //defult scence

        SceneManager.LoadScene(lastDeathScene, LoadSceneMode.Single); //load from the last scence the player died
    }
}
