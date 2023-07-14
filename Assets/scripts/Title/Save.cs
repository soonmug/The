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
  
    //inventoryManager 스크립트와 연결된 오브젝트를 찾아옴
       inventoryManager theInven = FindObjectOfType<inventoryManager>();
//위에서 가져와서 임시로 itemList에 덮어씌움
        List<item> itemList= theInven.inven;
        }
      
//파일 만들기?
        BinaryFormatter bf =new BinaryFormatter();
        FileStream file = File.Create(Application.dataPath+"/SaveFile.dat");
        //파일에 저장하고 직렬화?
        bf.Serialrze(file,data);
        file.Close();
          Debug.Log("인벤토리 아이템 저장완료");
    }

    public void CallLoad(public List<int> Items)
    {
        BinaryFormatter bf =new BinaryFormatter();
        FileStream file = File.Open(Application.dataPath+"/SaveFile.dat",FileMode.Open);
        
        if(file != null&& file.Length>0)
        {// file에서 데이터를 얻어왔기 때문에 data에는 기록이 남아있기 때문에 불러오기 가능
            data= (Data)bf.Deserialize(file);
            theInven = FindObjectOfType<inventoryManager>();
          
         }
      //인벤 아이템리스트와 이 아이템 리스트가 교체되면서 불러와짐  
            theInven.LoadItem(itemList);
          file.Close();
        else
        {
         Debug.Log("세이브 파일이 없습니다");
        }
 
    }
}
