using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickUp : MonoBehaviour
{

	void onTriggerEnter (Collider other)
	{


		if(other.CompareTag("Player"))
		{
			PlayerPickUp();
		}

	}   

	void PlayerPickUp()
	{
		Debug.Log("Power up picked up");
	}
    
}
