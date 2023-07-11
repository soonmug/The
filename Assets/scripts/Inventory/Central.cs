using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Central : MonoBehaviour
{
    public Transform invisibleCard;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void BeginDrag(Transform item)
    {
        Debug.Log("BeginDrag" + item.name);
       
    }
    void Drag(Transform item)
    {
        Debug.Log("Drag" + item.name);
    }
    void EndDrag(Transform item)
    {
        Debug.Log("End" + item.name);
    }
}
