using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInput : MonoBehaviour
{
    public PlayerConfig config;
    private float meleeAttackChargeTime = 0f;
    private float rangedAttackChargeTime = 0f;
    private bool hasDoubleJumped = false;

    private NewControlsClass newControls;
    public Vector2 MoveInput { get; private set; }
    public bool MoveLeftInput { get; private set; }
    public bool MoveRightInput { get; private set; }
    public bool JumpInput { get; private set; }
    public bool DashInput { get; private set; }
    public bool SprintInput { get; private set; }
    public bool GroundPoundInput { get; private set; }

    private InputAction moveAction;
    private InputAction moveLeftAction;
    private InputAction moveRightAction;
    private InputAction jumpAction;
    private InputAction dashAction;
    private InputAction sprintAction;
    private InputAction groundPoundAction;

    private void Awake()
    {
        newControls = new NewControlsClass();

        moveAction = newControls.Player.Move;
        moveAction.performed += OnMovePerformed;
        moveAction.canceled += OnMoveCanceled;
        moveAction.Enable();

        jumpAction = newControls.Player.Jump;
        jumpAction.started += OnJumpStarted;
        jumpAction.Enable();

        dashAction = newControls.Player.Dash;
        dashAction.started += OnDashStarted;
        dashAction.Enable();

        sprintAction = newControls.Player.Sprint;
        sprintAction.started += OnSprintStarted;
        sprintAction.Enable();

        groundPoundAction = newControls.Player.GroundPound;
        groundPoundAction.started += OnGroundPoundStarted;
        groundPoundAction.Enable();
    }

    private void OnMovePerformed(InputAction.CallbackContext context)
    {
        MoveInput = context.ReadValue<Vector2>();
    }

    private void OnMoveCanceled(InputAction.CallbackContext context)
    {
        MoveInput = Vector2.zero;
    }

    private void OnMoveLeftStarted(InputAction.CallbackContext context)
    {
        MoveLeftInput = true;
    }

    private void OnMoveLeftCanceled(InputAction.CallbackContext context)
    {
        MoveLeftInput = false;
    }

    private void OnMoveRightStarted(InputAction.CallbackContext context)
    {
        MoveRightInput = true;
    }

    private void OnMoveRightCanceled(InputAction.CallbackContext context)
    {
        MoveRightInput = false;
    }

    private void OnJumpStarted(InputAction.CallbackContext context)
    {
        JumpInput = true;
        Debug.Log("Jump started");
    }

    private void OnDashStarted(InputAction.CallbackContext context)
    {
        DashInput = true;
    }

    private void OnSprintStarted(InputAction.CallbackContext context)
    {
        SprintInput = true;
        Debug.Log("Sprint started");
    }

    private void OnGroundPoundStarted(InputAction.CallbackContext context)
    {
        GroundPoundInput = true;
    }

    private void OnEnable()
    {
        newControls.Enable();
    }

    private void OnDisable()
    {
        newControls.Disable();
    }

    void Update()
    {
        if (Keyboard.current.aKey.isPressed)
        {
            meleeAttackChargeTime += Time.deltaTime;
        }
        else
        {
            meleeAttackChargeTime = 0f;
        }

        if (Keyboard.current.dKey.isPressed)
        {
            rangedAttackChargeTime += Time.deltaTime;
        }
        else
        {
            rangedAttackChargeTime = 0f;
        }

        Debug.Log("JumpInput: " + JumpInput);
        Debug.Log("DashInput: " + DashInput);
        Debug.Log("SprintInput: " + SprintInput);
        Debug.Log("GroundPoundInput: " + GroundPoundInput);
    }

    public bool GetMeleeAttackTriggered()
    {
        return newControls.Player.MeleeAttack.triggered;
    }

    public bool GetRangedAttackTriggered()
    {
        return newControls.Player.RangedAttack.triggered;
    }

    public bool GetChargedMeleeAttackTriggered()
    {
        return meleeAttackChargeTime >= config.chargeTime;
    }

    public bool GetChargedRangedAttackTriggered()
    {
        return rangedAttackChargeTime >= config.chargeTime;
    }

    public bool CanDoubleJump()
    {
        if (!hasDoubleJumped)
        {
            hasDoubleJumped = true;
            return true;
        }
        return false;
    }

    public void ResetJump()
    {
        hasDoubleJumped = false;
    }
}
