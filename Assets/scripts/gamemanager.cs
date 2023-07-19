using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager:MonoBehaviour
{
    string filePath="/SaveItem.dat";
  
     List<Item> loadItemList=InventoryManager.Items;
   
    void Start()
    {
      
    }

    void Update()
    {

        if(Input.GetKeyDown(KeyCode.S))
        {
           Save.SaveItem(loadItemList,filePath);
        }

          if(Input.GetKeyDown(KeyCode.L))
        {
            loadItemList=Save.LoadItem(filePath);
        }
    }
      

}
