using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpSolarPanels : MonoBehaviour
{

    public bool SolarGemaakt = false;
    public PickUpHamer Hammer;
    public GameObject smoke;
    public GameObject smoke2;
    public GameObject smoke3;
    public GameObject smoke4;
    public GameObject smoke5;
    public GameObject smoke6;
    public GameObject smoke1;


    private void OnTriggerEnter(Collider other)
    {
        //check if player touches the gameobject with this script
        if (other.gameObject.tag == "Player")
        {
            // if Collider object is a solar panel, only activate THAT solar panel
             if (this.gameObject.tag == "Solar" && SolarGemaakt == false && Hammer.HamerGemaakt)
            {
                
                SolarPanelInvent.instance.AddPoint();
                SolarGemaakt = true;
                Destroy(GameObject.Find("smoke"));

            }
           else if (this.gameObject.tag == "Solar2" && SolarGemaakt == false && Hammer.HamerGemaakt)
            {
                SolarPanelInvent.instance.AddPoint();
                SolarGemaakt = true;
                Destroy(GameObject.Find("smoke1"));

            }
            else if (this.gameObject.tag == "Solar3" && SolarGemaakt == false && Hammer.HamerGemaakt)
            {
                SolarPanelInvent.instance.AddPoint();
                SolarGemaakt = true;
                Destroy(GameObject.Find("smoke2"));
            }
            else if (this.gameObject.tag == "Solar4" && SolarGemaakt == false && Hammer.HamerGemaakt)
            {
                SolarPanelInvent.instance.AddPoint();
                SolarGemaakt = true;
                Destroy(GameObject.Find("smoke3"));
            }
            else if (this.gameObject.tag == "Solar5" && SolarGemaakt == false && Hammer.HamerGemaakt)
            {
                SolarPanelInvent.instance.AddPoint();
                SolarGemaakt = true;
                Destroy(GameObject.Find("smoke4"));
            }
            else if (this.gameObject.tag == "Solar6" && SolarGemaakt == false && Hammer.HamerGemaakt)
            {
                SolarPanelInvent.instance.AddPoint();
                SolarGemaakt = true;
                Destroy(GameObject.Find("smoke6"));
            }
            else if (this.gameObject.tag == "Solar7" && SolarGemaakt == false && Hammer.HamerGemaakt)
            {
                SolarPanelInvent.instance.AddPoint();
                SolarGemaakt = true;
                Destroy(GameObject.Find("smoke5"));
            }



        }
    }
}
