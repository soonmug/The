using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager:MonoBehaviour
{
 public GameObject CoverImage;

    void Start()
    {
        
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
