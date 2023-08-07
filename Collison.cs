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
      Debug.Log("Ouch");   
    }
}
