using UnityEngine;
using UnityEngine.InputSystem;

public class MovementController : MonoBehaviour
{
    private NewControlsClass newControls;
    public Vector2 MoveInput { get; private set; }

    private void Awake()
    {
        newControls = new NewControlsClass();
        newControls.Enable();
    }

    private void OnMoveLeftPerformed(InputAction.CallbackContext context)
    {
        MoveInput = new Vector2(-1f, MoveInput.y);
    }

    private void OnMoveLeftCanceled(InputAction.CallbackContext context)
    {
        MoveInput = new Vector2(0f, MoveInput.y);
    }

    private void OnMoveRightPerformed(InputAction.CallbackContext context)
    {
        MoveInput = new Vector2(1f, MoveInput.y);
    }

    private void OnMoveRightCanceled(InputAction.CallbackContext context)
    {
        MoveInput = new Vector2(0f, MoveInput.y);
    }

    public void ResetJump()
    {
        // Add the logic to reset the jump state
    }

    public bool GetSprintActionTriggered()
    {
        // Add the logic to check if the sprint action is triggered
        return false; // Replace with your actual logic
    }

    public bool GetJumpActionTriggered()
    {
        // Add the logic to check if the jump action is triggered
        return false; // Replace with your actual logic
    }
}
