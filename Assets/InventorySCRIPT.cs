using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventorySCRIPT : MonoBehaviour
{
    [SerializeField] private Image inventoryImage;  // The UI Image that shows the current item
    [SerializeField] private Sprite defaultItemSprite;  // Default image when no item is selected
    [SerializeField] private Sprite[] itemSprites;  // Array to hold different item sprites

    // Call this function when the player picks up a new item
    public void UpdateInventory(int itemIndex)
    {
        if (itemIndex >= 0 && itemIndex < itemSprites.Length)
        {
            // Change the inventory image to the new item
            inventoryImage.sprite = itemSprites[itemIndex];
        }
        else
        {
            // Set back to the default image
            inventoryImage.sprite = defaultItemSprite;
        }
    }
}
