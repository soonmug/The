using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine.SceneManagement;

public class Save : MonoBehaviour
{
    [System.Serializable]
    public class Data
    {
        public List<int> Items;
    }
     private InventoryManager theInven;
   
     public void CallSave(public List<int> Items)
     {
  
    //inventoryManager ��ũ��Ʈ�� ����� ������Ʈ�� ã�ƿ�
       inventoryManager theInven = FindObjectOfType<inventoryManager>();
//������ �����ͼ� �ӽ÷� itemList�� �����
        List<item> itemList= theInven.inven;
        }
      
//���� �����?
        BinaryFormatter bf =new BinaryFormatter();
        FileStream file = File.Create(Application.dataPath+"/SaveFile.dat");
        //���Ͽ� �����ϰ� ����ȭ?
        bf.Serialrze(file,data);
        file.Close();
          Debug.Log("�κ��丮 ������ ����Ϸ�");
    }

    public void CallLoad(public List<int> Items)
    {
        BinaryFormatter bf =new BinaryFormatter();
        FileStream file = File.Open(Application.dataPath+"/SaveFile.dat",FileMode.Open);
        
        if(file != null&& file.Length>0)
        {// file���� �����͸� ���Ա� ������ data���� ����� �����ֱ� ������ �ҷ����� ����
            data= (Data)bf.Deserialize(file);
            theInven = FindObjectOfType<inventoryManager>();
          
         }
      //�κ� �����۸���Ʈ�� �� ������ ����Ʈ�� ��ü�Ǹ鼭 �ҷ�����  
            theInven.LoadItem(itemList);
          file.Close();
        else
        {
         Debug.Log("���̺� ������ �����ϴ�");
        }
 
    }
}
