using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drawer : MonoBehaviour
{
	 private Animator drawerAnimator;

    private void Start()
    {
        drawerAnimator = GetComponent<Animator>();
    }

    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider == GetComponent<Collider>())
                {
                    bool isOpen = drawerAnimator.GetBool("isOpen");
                    if (isOpen)
                    {
                        drawerAnimator.SetBool("isOpen", false);
                    }
                    else
                    {
                        drawerAnimator.SetBool("isOpen", true);
                    }
                }
            }
        }
    }
}