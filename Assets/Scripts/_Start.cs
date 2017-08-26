using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class _Start : MonoBehaviour {
  public GameObject stoper;
  public GameObject go_button;
  public GameObject retry_button;
  public GameObject canvas;

  public void onClick()
  {
    go_button.SetActive(false);
    GameObject rb = Instantiate(retry_button);
    rb.transform.SetParent(canvas.transform, false);
    Destroy(stoper);
  }
}
