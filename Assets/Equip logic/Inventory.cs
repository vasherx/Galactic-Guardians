using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public List<Item> items = new List<Item>();

    public bool AddItem(Item item)
    {
        if (items.Count >= 20)
        {
            Debug.Log("Inventory full!");
            return false;
        }

        items.Add(item);
        Debug.Log("Added item: " + item.itemName);
        return true;
    }

    public void RemoveItem(Item item)
    {
        if (items.Contains(item))
        {
            items.Remove(item);
            Debug.Log("Removed item: " + item.itemName);
        }
        else
        {
            Debug.Log("Item not found in inventory.");
        }
    }
}
