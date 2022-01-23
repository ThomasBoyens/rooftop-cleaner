using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreePlanter : MonoBehaviour
{
    public GameObject tree;

    public AudioClip PlantSound;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")  // check if the collided object has the Player tag
        {
            //print("tree planted");
            tree.GetComponent<Renderer>().enabled = true;           
            tree.GetComponent<Collider>().enabled = true;           
            gameObject.GetComponent<Collider>().isTrigger = false;  

            AudioSource.PlayClipAtPoint(PlantSound, transform.position);
            
            //Update UI
            TreeInventoryManager.instance.SubtractPoint();
        }
        
        
        
    }
}
