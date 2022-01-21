using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NextLevel : MonoBehaviour
{
     public string LevelToLoad = "";
     public GameObject NotEnoughCanvas;
     private int currScore ;
     
     void Update()
     {
         currScore = TrashInventoryManager.instance.Score;
         if (currScore < 20)
             NotEnoughCanvas.SetActive(true);
         else
            NotEnoughCanvas.SetActive(false);
     }
     
     void OnTriggerEnter(Collider other)
     {
         
         if (other.gameObject.CompareTag("Player") && LevelToLoad != "")
         {
             // later veranderen naar index als we zouden builden
             if (LevelToLoad == "Scene-2" && currScore == 20) // in level 1 to load level
             {
                 SceneManager.LoadScene(LevelToLoad);
                
             } 
             Debug.Log(currScore);
            


         }
     }
}
