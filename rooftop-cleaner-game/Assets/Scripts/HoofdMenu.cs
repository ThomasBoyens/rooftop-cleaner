using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HoofdMenu : MonoBehaviour
{
    public void LeaveGame()
    {
        Application.Quit();
        Debug.Log("quit");
    }
    
    public void StartGame()
    {
        Debug.Log("start");
        // level that loads when you press play
        SceneManager.LoadScene("Scenes/Level1"); 
    }


   
    

}
