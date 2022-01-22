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
        if (LevelToLoad == "Level2")
        {
            currentScore = TrashInventoryManager.instance.Score;

            // if the score is less then 20 show the text not enough, if currScore == 20 make Canvas invisible
            if (currentScore < 20)
                NotEnoughCanvas.SetActive(true);
            else
                NotEnoughCanvas.SetActive(false);
        }
        else if (LevelToLoad == "Level3")
        {
            currentScore = InventoryManager.instance.remainingTrees;
            
            // if the score is less then 20 show the text not enough, if currScore == 20 make Canvas invisible
            if (currentScore > 0)
                NotEnoughCanvas.SetActive(true);
            else
                NotEnoughCanvas.SetActive(false);
                
            }
        else if (LevelToLoad == "Hoofdmenu-0")
        {
            currentScore = SolarPanelInvent.instance.score;
        }
    
    }
     
     void OnTriggerEnter(Collider other)
     {
         // if player collides with obj and level is not null advance to nextLevel
         if (other.gameObject.CompareTag("Player") && LevelToLoad != "")
         {
             // check wich level has to be loaded
             // in level 1 to load level2 if score is 20 load next level
             if (LevelToLoad == "Level2" && currentScore == 20) 
                 SceneManager.LoadScene(LevelToLoad);
             
             // in level 2 to load level3 if all the trees where planeted(score==0)load next level
             else if (LevelToLoad=="Level3" && currentScore == 0)
                 SceneManager.LoadScene(LevelToLoad);   
             
             // in level 3 to load level4 if all solarpanels are repaired(score == 7) load next level
             else if (LevelToLoad == "Hoofdmenu-0" && currentScore == 7) 
                 SceneManager.LoadScene(LevelToLoad);
             
            
            


         }
     }
}
