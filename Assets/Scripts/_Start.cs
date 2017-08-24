using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _Start : MonoBehaviour {
  public GameObject stoper;
  // Use this for initialization
  void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

  public void onClick()
  {
    Destroy(stoper);
  }
}
