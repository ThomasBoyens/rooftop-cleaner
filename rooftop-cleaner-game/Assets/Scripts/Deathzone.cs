using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deathzone : MonoBehaviour
{

    [SerializeField] private Transform player;
    [SerializeField] private Transform respawnPoint;
    void onTriggerEnter(Collider other)
    {
        player.transform.position = respawnPoint.transform.position;
        
    }
}
