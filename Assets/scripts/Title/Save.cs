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

    public void CallSave()
    {//inventoryManager ��ũ��Ʈ�� ã�ƿ� ����?
        theInven = FindObjectOfType<inventoryManager>();
//������ �����ͼ� �ӽ÷� itemList�� �����
        List<item> itemList= theInven.inven

        Debug.Log("�κ��丮 ������ ����Ϸ�");
//���� �����?
        BinaryFormatter bf =new BinaryFormatter();
        FileStream file = FileCreate(Application.dataPath+"/SaveFile.dat");
        //���Ͽ� �����ϰ� ����ȭ?
        bf.Serialrze(file,data);
        file.Close();
    }

    public void CallLoad()
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
        
        else
        {
         Debug.Log("���̺� ������ �����ϴ�");
        }
          file.Close();
}
