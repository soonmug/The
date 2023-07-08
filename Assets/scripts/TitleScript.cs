using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleScript : MonoBehaviour
{
    void Update()
    {//마우스 왼쪽을 누르면 Room scene으로 이동
      if(Input.GetMouseButtonDown(0))
      {
      Application.LoadLevel("Room");
      }
    }
   
}

