  using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour {
  public GameObject kids;
  public GameObject kids_banzai;

  void OnTriggerEnter2D(Collider2D nudle)
  {
    Debug.Log("goal");
    Destroy(kids);
    Instantiate(kids_banzai);
  }
}
