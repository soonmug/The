using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChaing : MonoBehaviour
{
    //���콺�� ������ Room scene���� �̵�
     public void ButtonClick()
     {
        SceneManager.LoadScene("Room");
      }
   
}

