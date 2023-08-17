using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collison : MonoBehaviour
{

    void OnCollisionEnter2D(Collision2D other)
    {
     Debug.Log("somthing happend");    
    }
    void OnTriggerEnter2D(Collider2D other)
    {
     if (other.tag == "Package")
     {
      Debug.Log("Package picked up");
     }

     if(other.tag == "Customer"){
      Debug.Log("Package Devilered");
     }
    }
}
