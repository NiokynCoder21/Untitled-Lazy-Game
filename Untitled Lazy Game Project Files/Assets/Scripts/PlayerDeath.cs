using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDeath : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("ground")) //if collided game object has ground tag
        {
            SceneManager.LoadScene("SampleScene", LoadSceneMode.Single); //load the sameple scence basicallys restarts the level
        }
    }
}
