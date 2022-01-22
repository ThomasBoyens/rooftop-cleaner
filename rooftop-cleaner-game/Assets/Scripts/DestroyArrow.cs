using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyArrow : MonoBehaviour
{
    public GameObject arrow;

    private void OnTriggerEnter(Collider other)
    {
        Destroy(arrow.gameObject);
    }
}
