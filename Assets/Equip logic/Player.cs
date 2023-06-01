using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Inventory inventory;
    public Equipment equipment;
    public Potion somePotion;
    public Armor someArmor;
    public Weapon someWeapon;
    
    void Start()
    {
        // Add some items to the inventory
        inventory.AddItem(somePotion);
        inventory.AddItem(someArmor);
        inventory.AddItem(someWeapon);
        
        // Equip some items
        equipment.EquipArmor(someArmor);
        equipment.EquipWeapon(someWeapon);
    }
    
    void Update()
    {
        // Check for input to use items
        if (Input.GetKeyDown(KeyCode.I))
        {
            // Use the first item in the inventory
            if (inventory.items.Count > 0)
            {
                inventory.items[0].Use();
                inventory.RemoveItem(inventory.items[0]);
            }
        }
    }
}
