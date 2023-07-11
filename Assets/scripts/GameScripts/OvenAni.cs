using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OvenAni : MonoBehaviour
{
    public bool ovenAni;
    public Animator animator;

    private Manager manager;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        manager = GameObject.Find("GameManager").GetComponent<Manager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        if (manager.itemThuch == true)
        {
            if (ovenAni == false)
            {
                animator.SetBool("Open", true);
                ovenAni = true;
            }
            else
            {
                animator.SetBool("Open", false);
                ovenAni = false;
            }
        }
                     
    }
}
