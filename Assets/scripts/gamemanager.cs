using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager:MonoBehaviour
{
 public GameObject CoverImage;

 private Save theSave;
    void Start()
    {
        theSave=FindObjectOfType<Save>();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F5))
        {
            theSave.CallSave();
        }

          if(Input.GetKeyDown(KeyCode.F9))
        {
            theSave.CallLode();
        }
    }
}
