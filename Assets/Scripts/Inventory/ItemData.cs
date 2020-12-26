using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Inventory/Item")]
public class ItemData : ScriptableObject
{
    public int id;
    public string name;
    public Sprite sprite;
    public GameObject prefab;
    public bool stackable;
}
