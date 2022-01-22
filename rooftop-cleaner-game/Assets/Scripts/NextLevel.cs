using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NextLevel : MonoBehaviour
{
    // level thats has to be loaded (needs to be in the build)
     public string LevelToLoad = "";
     
     // canvas with text saying that you do not have enough to advance to the next level
     public GameObject NotEnoughCanvas;
     
     // current player score
     private int currentScore;
     
     void Update()
     {
         // get score from the inventory manger,check score every frame on advancements
         currentScore = TrashInventoryManager.instance.Score;
         // if the score is less then 20 show the text not enough, if currScore == 20 make Canvas invisible
         if (currentScore < 20)
             NotEnoughCanvas.SetActive(true);
         else
            NotEnoughCanvas.SetActive(false);
     }
     
     void OnTriggerEnter(Collider other)
     {
         // if player collides with obj and level is not null advance to nextLevel
         if (other.gameObject.CompareTag("Player") && LevelToLoad != "")
         {
             // check wich level has to be loaded
             // in level 1 to load level2 if score is 20 load next level
             if (LevelToLoad == "Scene-2" && currentScore == 20) 
                 SceneManager.LoadScene(LevelToLoad);
             
             // in level 2 to load level3 if all the trees where planeted(score==0)load next level
             else if (LevelToLoad=="Scene-3" && currentScore == 0)
                 SceneManager.LoadScene(LevelToLoad);   
             
             // in level 3 to load level4 if all solarpanels are placed(score == X) load next level
             else if (LevelToLoad == "Scene-4" && currentScore == 1) 
                 SceneManager.LoadScene(LevelToLoad);
             
            
            


         }
     }
}
