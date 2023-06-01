using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerStates : MonoBehaviour
{
    public bool IsGrounded { get; private set; }
    public bool IsTouchingWall { get; private set; }
    public bool IsInAir { get { return !IsGrounded; } }

    private float timeSinceGrounded = 0f;
    private Collider2D playerCollider;

    public PlayerConfig config;
    public MovementController movementController;

    void Awake()
    {
        playerCollider = GetComponent<Collider2D>();
    }

    void Update()
    {
        IsGrounded = Physics2D.IsTouchingLayers(playerCollider, config.groundLayer);
        IsTouchingWall = CheckWallTouch();

        if (IsGrounded)
        {
            timeSinceGrounded = 0;
            movementController.ResetJump();
        }
        else
        {
            timeSinceGrounded += Time.deltaTime;
        }
    }

    public bool CanJump()
    {
        return IsGrounded || timeSinceGrounded < config.coyoteTime;
    }

    private bool CheckWallTouch()
    {
        float horizontalInput = movementController.MoveInput.x;
        RaycastHit2D hit = Physics2D.Raycast(playerCollider.bounds.center, Vector2.right * horizontalInput, playerCollider.bounds.extents.x + config.wallGrabThreshold, config.groundLayer);
        return hit;
    }
}
