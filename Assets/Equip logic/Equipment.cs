using UnityEngine;

public class Equipment : MonoBehaviour
{
    public Weapon equippedWeapon;
    public Armor equippedArmor;

    public void EquipWeapon(Weapon weapon)
    {
        if (equippedWeapon != null)
        {
            Debug.Log("Unequipping weapon: " + equippedWeapon.itemName);
        }

        equippedWeapon = weapon;
        Debug.Log("Equipped weapon: " + weapon.itemName);
    }

    public void EquipArmor(Armor armor)
    {
        if (equippedArmor != null)
        {
            Debug.Log("Unequipping armor: " + equippedArmor.itemName);
        }

        equippedArmor = armor;
        Debug.Log("Equipped armor: " + armor.itemName);
    }
}
