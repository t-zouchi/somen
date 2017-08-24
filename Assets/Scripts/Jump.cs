using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour {
  Rigidbody2D rb = null;
  void Start()
  {
     rb = GetComponent<Rigidbody2D>();
  }



  void OnTriggerEnter2D(Collider2D colider)
  {
    if(colider.tag == "Jump")
    {
      rb.AddForce(transform.up * 400);
      Debug.Log("jump");
    }
    
    
  }
}
