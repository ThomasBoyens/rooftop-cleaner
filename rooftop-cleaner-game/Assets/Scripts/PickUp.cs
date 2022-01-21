using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    
    public bool SolarGemaakt = false;
    public PickUpHamer pH;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.tag == "Player")
            {
                if (this.gameObject.tag == "trashBag")
                {
                    TrashInventoryManager.instance.AddPoint();
                    Destroy(gameObject);
                }
               
                else if (this.gameObject.tag == "Solar" && SolarGemaakt == false && pH.HamerGemaakt)
                {
                    SolarPanelInvent.instance.AddPoint();
                    SolarGemaakt = true;
                   
                }



        }
        }
}
