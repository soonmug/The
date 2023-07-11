using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickUp : MonoBehaviour
{
    public Item Item;
    private Manager manager;

    private void Start()
    {
        manager = GameObject.Find("GameManager").GetComponent<Manager>();
    }
    void Pickup()
    {
        if (manager.itemThuch == true)
        {
            //터치가 가능한 오브젝트일 경우
            InventoryManager.Instance.Add(Item);
            //Item리스트에 터치한 아이템 정보를 넘김
            Destroy(gameObject);
        }
    
    }
    // Start is called before the first frame update
    private void OnMouseDown()
    {
        
        Pickup();
    }
}
