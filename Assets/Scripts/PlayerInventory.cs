using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    public string itemInInventory = null; // Store the name of an item

    public bool HasItem()
    {
        return itemInInventory != null;
    }

    public string GiveItem()
    {
        string item = itemInInventory;
        itemInInventory = null; // Remove item from inventory
        return item;
    }

    public void AddItem(string newItem)
    {
        itemInInventory = newItem;
    }
}
