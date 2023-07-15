using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager:MonoBehaviour
{
    string filePath="/SaveItem.dat";
  
    private  List<Item> items;
   
   
    void Start()
    {
      items=new List<Item>();
    }

    void Update()
    {

        

        if(Input.GetKeyDown(KeyCode.S))
        {
           Save.SaveItem(items,filePath);
        }

          if(Input.GetKeyDown(KeyCode.L))
        {
            items=Save.LoadItem(filePath);
        }
    }
}
