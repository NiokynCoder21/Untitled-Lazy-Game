using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowClicker : MonoBehaviour
{
    void Start()
    {
        Cursor.lockState = CursorLockMode.None;//locks the cursor when the game begins
        Cursor.visible = true; //ensure the cursor is not visible 
    }

   
}
