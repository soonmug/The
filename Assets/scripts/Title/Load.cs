using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Load : MonoBehaviour
{
    string filePath="/SaveItem.dat";
    
     List<Item> loadItemList;

     private void Awake()
     {
      loadItemList = Save.LoadItem(filePath);
     }

     public void ButtonClick()
       {
            loadItemList=Save.LoadItem(filePath);
       }
     public void ButtonClick1()
       {
           Save.SaveItem(loadItemList,filePath);
        }

}
