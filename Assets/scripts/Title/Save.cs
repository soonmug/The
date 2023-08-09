using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;
using System.Collections.Generic;


public class Save
{

    public static void SaveItem(List<Item> Items,string filePath)
    {
        
        BinaryFormatter formatter = new BinaryFormatter();
        if (File.Exists(filePath))
    {
        File.Delete(filePath); // 기존 파일 삭제
    }
        FileStream file = File.Create(Path.Combine(Application.persistentDataPath, filePath));
    
        formatter.Serialize(file, Items);
    
        file.Close();
        Debug.Log(Application.dataPath + "의 위치에 저장했습니다");
      
    }
    
     public static List<Item> LoadItem(string filePath)
    {
        if  (File.Exists(Path.Combine(Application.persistentDataPath, filePath)))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream file = File.Open(Path.Combine(Application.persistentDataPath, filePath), FileMode.Open);
    
            List<Item> inventoryManager = formatter.Deserialize(file) as List<Item>;
    
            file.Close();
     
             inventoryManager = new List<Item>();

        // itemList를 inventoryManager에 할당하는 로직
       
        return inventoryManager;
        }


        else
        {
            Debug.LogError("파일이 존재하지 않습니다");
            return null;
        }
    }
}