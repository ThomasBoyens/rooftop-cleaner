using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialScreen : MonoBehaviour
{

    public GameObject TutorialCanvas;

    private void OnTriggerEnter(Collider other)
    {
        // if player touches the object the TutorialCanvas is set invisible
        if (other.gameObject.tag == "Player")
            TutorialCanvas.SetActive(false);
          
    }
}
