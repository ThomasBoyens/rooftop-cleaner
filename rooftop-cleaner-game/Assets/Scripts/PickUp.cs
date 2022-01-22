using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    
    public bool SolarGemaakt = false;
    public PickUpHamer Hammer;

    // soundClip that has to play
    public AudioClip PickUpSound;
    
     private void OnTriggerEnter(Collider other)
        {
            //check if player touches the gameobject with this script
            if (other.gameObject.tag == "Player")
            {
                // if Collider object is a trashbag then play sound, addpoint , destroy trashbag
                if (this.gameObject.tag == "trashBag")
                {
                    // play sound at point before gameobject is destoryed otherwise you the sound won't play
                    AudioSource.PlayClipAtPoint(PickUpSound, transform.position);
                    TrashInventoryManager.instance.AddPoint();
                    Destroy(gameObject);
                   
                }
               
                else if (this.gameObject.tag == "Solar" && SolarGemaakt == false && Hammer.HamerGemaakt)
                {
                    SolarPanelInvent.instance.AddPoint();
                    SolarGemaakt = true;
                   
                }



        }
        }
}
