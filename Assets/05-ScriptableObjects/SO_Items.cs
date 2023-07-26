using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Item")]
public class SO_Items : ScriptableObject
{
    public string itemName;
    public string itemCode;
    public Sprite itemIcon;
    public Sprite goldIcon;
    public int value;
}
