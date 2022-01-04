using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
	public float damageAmount = 10.0f;

	void OnTriggerEnter(Collider collision)						// used for things like bullets, which are triggers.  
	{
		if (collision.gameObject.GetComponent<Health> () != null) {	// if the hit object has the Health script on it, deal damage
				collision.gameObject.GetComponent<Health> ().ApplyDamage (damageAmount);
		
		}
	}

}
