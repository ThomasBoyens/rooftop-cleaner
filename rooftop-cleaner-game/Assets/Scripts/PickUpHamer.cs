using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpHamer : MonoBehaviour
{
    public bool HamerGemaakt = false;
    public AudioSource pickupSound;


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
            if (this.gameObject.tag == "hammer")
            {
                pickupSound.Play();
                HamerGemaakt = true;
                HammerInvent1.instance.AddPoint();
                Destroy(gameObject);
                
            }
            



        }
    }
}
