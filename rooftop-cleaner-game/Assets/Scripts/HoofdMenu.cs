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
        SceneManager.LoadScene("Scenes/Level1"); // hier komt naam lvl 1
    }

    

}
