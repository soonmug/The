using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Camera : MonoBehaviour
{
    private Animator cameraAni;
    private Manager manager;
   
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
        manager.itemThuch = false;

    }
    public void CameraDesk()
    {
        cameraAni.SetBool("Desk",true);
        cameraAni.SetBool("MinWall_001", false);
        Invoke("itemThuch", 0.5f);
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
    public void itemThuch()
    {
        manager.itemThuch = true;
    }
    public void leftdownThuch()
    {
        manager.leftDownThuch = true;
    }
}
