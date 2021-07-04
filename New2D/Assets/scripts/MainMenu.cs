using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    
    public void ExitGame()
    {
        Debug.Log("Game has been closed!");
        Application.Quit();
    }

}
