using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Scriptable Objects/Inventory Item", fileName = "New Inventory Item")]
public class InventoryItem : ScriptableObject
{
    public Sprite mySprite;
    public string myName;
    public string myDescription;
    public bool isUsable;
    public bool isUnique;
    public int numberHeld;
}
