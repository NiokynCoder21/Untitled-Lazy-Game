using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class PlayerWin : MonoBehaviour
{
    public KeyManager keyManager;
    public TMP_Text notEngoughKeys;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player")) //if collided game object has player tag
        {

            if (keyManager != null)
            {
                if (keyManager.currentAmount == 0)
                {
                    SceneManager.LoadScene("WinScreen", LoadSceneMode.Single); //load the tutorial scence
                }

                else
                {
                    notEngoughKeys.gameObject.SetActive(true); //show text
                }

            }
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player")) //if collided game object has player tag
        {
           notEngoughKeys.gameObject.SetActive(false); //hide text
        }
    }
}
