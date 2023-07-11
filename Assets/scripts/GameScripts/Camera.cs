using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Camera : MonoBehaviour
{
    private Animator cameraAni;
    private Manager manager;

    // 카메라애니메이션에 대한 스크립트
    //화면전환 후 0.5초 뒤 상호작용가능한 오브젝트 터치 가능
   
    // Start is called before the first frame update
    void Start()
    {
        manager = GameObject.Find("GameManager").GetComponent<Manager>();
        cameraAni = GetComponent<Animator>();
    }

    // Update is called once per frame
    public void CameraAll()
    {
        cameraAni.SetBool("All", true);
        cameraAni.SetBool("MinWall_002", false);
        cameraAni.SetBool("MinWall_001", false);
        //카메라 애니메이터 제어
        manager.itemThuch = false;
        //아이템 터치 불가능/가능에 대한 Bool

    }
    public void CameraDesk()
    {
        cameraAni.SetBool("Desk",true);
        cameraAni.SetBool("MinWall_001", false);
        Invoke("itemThuch", 0.5f);
        //0.5초 뒤 터치 가능
    }
    public void CameraDeskUp()
    {
        cameraAni.SetBool("DeskUp", true);
        cameraAni.SetBool("MinWall_001", false);
        Invoke("itemThuch", 0.5f);
    }
    public void CameraDeskDown()
    {
        cameraAni.SetBool("DeskDown", true);
        cameraAni.SetBool("MinWall_001", false);
        Invoke("itemThuch", 0.5f);
    }
    public void CameraLeftUp()
    {
        cameraAni.SetBool("LeftUp", true);
        cameraAni.SetBool("MinWall_001", false);
        Invoke("itemThuch", 0.5f);
    }
    public void CameraLeftDown()
    {
        cameraAni.SetBool("LeftDown", true);
        cameraAni.SetBool("MinWall_001", false);
        Invoke("leftdownThuch", 0.5f);
    }
    public void CameraWall001()
    {
        manager.itemThuch = false;
        manager.leftDownThuch = false;
        cameraAni.SetBool("MinWall_001", true);
        cameraAni.SetBool("All", false);
        cameraAni.SetBool("Desk", false);
        cameraAni.SetBool("DeskUp", false);
        cameraAni.SetBool("DeskDown", false);
        cameraAni.SetBool("LeftUp", false);
        cameraAni.SetBool("LeftDown", false);
        
    }
    public void CameraWall002()
    {
        cameraAni.SetBool("MinWall_002", true);
        cameraAni.SetBool("All", false);
        Invoke("itemThuch", 0.5f);
    }
    //아래는 아이템 터치에 관한 부분
    public void itemThuch()
    {
        manager.itemThuch = true;
    }
    public void leftdownThuch()
    {
        manager.leftDownThuch = true;
    }
}
