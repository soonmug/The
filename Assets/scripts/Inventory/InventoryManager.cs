using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

[Serializable]
public class InventoryManager : MonoBehaviour
{
    public static InventoryManager Instance;
    public List<Item> Items = new List<Item>();

    public Transform ItemContent;
    public GameObject InventoryItem;

    private void Awake()
    {
        Instance = this;
    }
    public void Add(Item item)
    {
        Items.Add(item);
        ListItems();
        //item�� Items����Ʈ�� �߰��ϴ°� ���� �� ��
    }
    public void ListItems()
    {
        foreach(Transform item in ItemContent)
        {
            //���ӿ�����Ʈ ����
            Destroy(item.gameObject);
        }
        foreach (var item in Items)
        {
            //Items��Ͽ� item�� ������
            GameObject obj = Instantiate(InventoryItem, ItemContent);
            var itemIcon = obj.transform.Find("ItemIcon").GetComponent<Image>();
            var itemName = obj.transform.Find("ItemName").GetComponent<Text>();
            //Image�� Text ������Ʈ�� ���� �����͸� �޾ƿ� InventoryItem�� ItemContent�� ������ ����

            itemIcon.sprite = item.icon;
            itemName.text = item.itemName;

        }
    }
}
