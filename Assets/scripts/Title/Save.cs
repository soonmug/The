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
        File.Delete(filePath); // ���� ���� ����
    }
        FileStream file = File.Create(Path.Combine(Application.persistentDataPath, filePath));
    
        formatter.Serialize(file, Items);
    
        file.Close();
        Debug.Log(Application.dataPath + "�� ��ġ�� �����߽��ϴ�");
      
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