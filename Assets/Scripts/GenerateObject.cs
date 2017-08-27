using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateObject : MonoBehaviour {
  public GameObject prefab;
  GameObject inst_obj;
  bool obj_status = false;

  void start()
  {
    obj_status = false;
  }
  
  public void onclick()
  {
    if (obj_status)
    {
      destroy_obj();
      obj_status = false;
    }
    else
    {
      generate();
      obj_status = true;
    }
  }

  void generate()
  {
    Vector2 position = new Vector2(-7.5f, -3.5f);
    inst_obj = Instantiate(prefab);
    inst_obj.transform.position = position;
  }

  void destroy_obj()
  {
    Destroy(inst_obj);
  }
}
