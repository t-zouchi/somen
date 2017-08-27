  using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour {
  public GameObject kids;
  public GameObject kids_banzai;

  void OnTriggerEnter2D(Collider2D nudle)
  {
    Destroy(kids);
    Instantiate(kids_banzai);
    Invoke("return_select", 3.5f);
  }

  void return_select()
  {
    SceneManager.LoadScene("Select");
  }
}
