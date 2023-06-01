using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerConfig", menuName = "ScriptableObjects/PlayerConfig", order = 1)]
public class PlayerConfig : ScriptableObject
{
    public float speed = 5f;
    public float sprintSpeedMultiplier = 1.5f;
    public float jumpForce = 5f;
    public float dashForce = 10f;
    public float dashDuration = 0.5f;
    public float coyoteTime = 0.2f;
    public float wallGrabThreshold = 0.1f;
    public LayerMask groundLayer;
    
    // New jump parameters
    public float jumpTime = 0.4f; // Max time the player can keep ascending in a jump
    public float airControlSpeed = 3f; // Lateral speed in the air
    public float wallSlideSpeed = 2f; // Vertical speed during a wall slide
    public int maxJumps = 1; // Maximum number of jumps
    
    // Other parameters
    public float meleeDamage = 5f;
    public float rangedDamage = 3f;
    public float chargedMeleeDamage = 10f;
    public float chargedRangedDamage = 10f;
    public float chargeTime = 1.5f;
    public float blockChipDamage = 2f;
}
