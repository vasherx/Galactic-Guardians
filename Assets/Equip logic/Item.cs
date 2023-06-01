using UnityEngine;

[CreateAssetMenu(fileName = "NewItem", menuName = "Inventory/Item")]
public class Item : ScriptableObject
{
    public string itemName;
    public Sprite itemIcon;
    public string itemDescription;

    public virtual void Use()
    {
        // Default use method for generic items
        Debug.Log("Using item: " + itemName);
    }
    
}
