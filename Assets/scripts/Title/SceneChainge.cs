using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScript : MonoBehaviour
{
    //마우스를 누르면 Room scene으로 이동
     public void ButtonClick()
     {
        SceneManager.LoadScene("Room");
      }
   
}

