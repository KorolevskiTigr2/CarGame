using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
// variables
  [SerializeField] float steerSpeed = 100f;
  [SerializeField] float moveSpeed = 100f;

    void Start()
    {
         
    }

    void Update()
    {
      float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
      float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
      transform.Rotate(0,0,-steerAmount);
      transform.Translate(0,moveAmount,0);
    }
}
