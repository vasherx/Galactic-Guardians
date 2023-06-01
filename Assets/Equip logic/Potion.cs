using UnityEngine;

[CreateAssetMenu(fileName = "NewPotion", menuName = "Inventory/Potion")]
public class Potion : Item
{
    public int healAmount;

    public override void Use()
    {
        base.Use();
        // Heal the player
        Debug.Log("Healing player for " + healAmount + " health.");
    }
}

