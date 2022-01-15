using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deathzone : MonoBehaviour
{
    void onTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
    }
}
