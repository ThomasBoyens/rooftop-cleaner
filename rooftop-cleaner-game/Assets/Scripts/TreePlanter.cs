using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreePlanter : MonoBehaviour
{
    public GameObject tree;

    public AudioClip PlantSound;

    void start()
    {
        //tree.GetComponent<Renderer>().enabled = false;
    }
    
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            //print("tree planted");
            tree.GetComponent<Renderer>().enabled = true;
            tree.GetComponent<Collider>().enabled = true;
            gameObject.GetComponent<Collider>().isTrigger = false;

            AudioSource.PlayClipAtPoint(PlantSound, transform.position);
            
            //Update UI
            InventoryManager.instance.SubtractPoint();
        }
        
        
        
    }
}
