using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerUp : MonoBehaviour
{
   
   public GameObject pickupEffect;

    void OnCollisionEnter(Collision otherObj)
    {
        if (otherObj.gameObject.tag == "Player") {
         Pickup();
        }
    }


   void Pickup()
   {
   	Debug.Log("Powe pick up");
   }
}

