using UnityEngine;

[CreateAssetMenu(fileName = "NewArmor", menuName = "Inventory/Armor")]
public class Armor : Item
{
    public int defenseValue;

    public override void Use()
    {
        base.Use();
        // Equip the armor
        Debug.Log("Equipping armor with defense value: " + defenseValue);
    }
}

