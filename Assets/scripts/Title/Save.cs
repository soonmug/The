using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;
using System.Collections.Generic;

public class Save
{

     public static void SaveItem(List<Item> Items, string filePath)
    {
        
        BinaryFormatter formatter = new BinaryFormatter();
        FileStream file = File.Create(filePath);
    
        formatter.Serialize(file, Items);
    
        file.Close();
    }
    
     public static List<Item> LoadItem(string filePath)
    {
        if (File.Exists(filePath))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream file = new FileStream(filePath, FileMode.Open);
    
            List<Item> inventoryManager = formatter.Deserialize(file) as List<Item>;
    
            file.Close();
     
             inventoryManager = new List<Item>();

        // itemList�� inventoryManager�� �Ҵ��ϴ� ����
       
        return inventoryManager;
        }

        else
        {
            Debug.LogError("������ �������� �ʽ��ϴ�");
            return null;
        }
    }
}