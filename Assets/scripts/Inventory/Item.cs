using UnityEngine;
using System;

//아이템 정보를 담은 파일 생성가능
//프로젝트 창>우클릭>Creat
//자세한건 ScriptableObject 검색
[CreateAssetMenu(fileName ="New Item",menuName ="Item/Create New Item")]
public class Item : ScriptableObject
{
    public int id;
    public string itemName;
    public int value;
    public Sprite icon;

    
}
