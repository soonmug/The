using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleScript : MonoBehaviour
{
    void Update()
    {//���콺 ������ ������ Room scene���� �̵�
      if(Input.GetMouseButtonDown(0))
      {
      Application.LoadLevel("Room");
      }
    }
   
}

