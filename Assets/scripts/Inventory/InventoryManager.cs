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
        //item을 Items리스트에 추가하는것 같음 잘 모름
    }
    public void ListItems()
    {
        foreach(Transform item in ItemContent)
        {
            //게임오브젝트 삭제
            Destroy(item.gameObject);
        }
        foreach (var item in Items)
        {
            //Items목록에 item이 들어오면
            GameObject obj = Instantiate(InventoryItem, ItemContent);
            var itemIcon = obj.transform.Find("ItemIcon").GetComponent<Image>();
            var itemName = obj.transform.Find("ItemName").GetComponent<Text>();
            //Image와 Text 컴포넌트에 대한 데이터를 받아온 InventoryItem을 ItemContent의 하위에 생성

            itemIcon.sprite = item.icon;
            itemName.text = item.itemName;

        }
    }
}
