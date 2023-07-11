using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OvenAni : MonoBehaviour
{
    //상호작용하여 애니메이션이 있는 오브젝트에 대한 스크립트(서랍열고 닫기)
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
            //만약 터치가 가능한 오브젝트일 경우
        {
            if (ovenAni == false)//이러한 조건하에
            {
                animator.SetBool("Open", true);
                ovenAni = true;
                //오브젝트를 연다
            }
            else
            {
                animator.SetBool("Open", false);
                ovenAni = false;
                //닫는다
            }
        }
                     
    }
}
