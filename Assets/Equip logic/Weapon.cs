using UnityEngine;

[CreateAssetMenu(fileName = "NewWeapon", menuName = "Inventory/Weapon")]
public class Weapon : Item
{
    public int attackValue;

    public override void Use()
    {
        base.Use();
        // Equip the weapon
        Debug.Log("Equipping weapon with attack value: " + attackValue);
    }
}
