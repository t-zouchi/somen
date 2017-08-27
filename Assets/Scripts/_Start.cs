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

  public void gameStart()
  {
    SceneManager.LoadScene("Select");
  }

  public void loadStage1()
  {
    SceneManager.LoadScene("Stage1");
  }

  public void loadStage2()
  {
    SceneManager.LoadScene("Stage2");
  }

  public void loadStage3()
  {
    SceneManager.LoadScene("Stage3");
  }

  public void loadStage4()
  {
    SceneManager.LoadScene("Stage4");
  }

  public void loadStage5()
  {
    SceneManager.LoadScene("Stage5");
  }

  public void loadStage6()
  {
    SceneManager.LoadScene("Stage6");
  }
  
}
