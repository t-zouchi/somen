using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Jump : MonoBehaviour {
  Rigidbody2D rb = null;
  public float power = 400;
  void Start()
  {
     rb = GetComponent<Rigidbody2D>();
  }

  void OnTriggerEnter2D(Collider2D colider)
  {
    if(colider.tag == "Jump")
    {
      rb.AddForce(transform.up * power);
      rb.velocity =new Vector2(power * 0.5f, power);
    }
  }
}
