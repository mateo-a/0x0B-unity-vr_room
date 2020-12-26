using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryControl : MonoBehaviour
{
    public ItemData[] itemData;
    public InventoryItem[] inventoryItems;
    ItemData tempItemData;
    public Transform hand;

    public void AddItem(ItemData item)
    {
        foreach (InventoryItem current in inventoryItems)
        {
            if (current.itemData == null)
            {
                current.itemData = item;
                // current.text.text = item.name;
                current.image.sprite = item.sprite;
                return;
            }
        }
    }
    public void SwapItem(ItemData item)
    {
        for (int i = 0; i < 4; i++)
        {
            inventoryItems[i].itemData = inventoryItems[i + 1].itemData;
            inventoryItems[i].image.sprite = inventoryItems[i + 1].image.sprite;
        }
        inventoryItems[4].itemData = null;
        inventoryItems[4].image.sprite = null;
    }

    public void DeleteItems()
    {
        foreach (InventoryItem current in inventoryItems)
        {
            Transform dropping = hand.GetChild(0);
            if (current.itemData != null && current.itemData.name != "key_gold")
            {
                current.itemData = null;
                // current.text.text = item.name;
                current.image.sprite = null;
                dropping.position = transform.position;
                dropping.parent = null;
                dropping.GetComponent<Rigidbody>().isKinematic = false;
            }
        }
    }

    public bool CheckItem()
    {
        foreach (InventoryItem current in inventoryItems)
        {
            if (current.itemData && current.itemData.name == "key_gold")
            {
                return true;
            }
        }
        return false;
    }

    public int CountItems()
    {
        int i = 0;
        foreach (InventoryItem current in inventoryItems)
        {
            if (current.itemData != null)
            {
                i++;
            }
        }
        return i;
    }

}
