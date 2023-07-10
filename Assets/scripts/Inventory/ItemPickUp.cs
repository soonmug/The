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
            InventoryManager.Instance.Add(Item);
            Destroy(gameObject);
        }
    
    }
    // Start is called before the first frame update
    private void OnMouseDown()
    {
        
        Pickup();
    }
}
