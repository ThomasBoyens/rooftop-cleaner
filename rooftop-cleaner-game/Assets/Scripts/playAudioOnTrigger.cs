using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playAudioOnTrigger : MonoBehaviour
{
    public AudioSource audioKeuze;
    private void OnTriggerEnter(Collider other)
    {
        audioKeuze.Play();
    }
}
