using UnityEngine;
using UnityEngine.InputSystem;

public class PersonalInputActions_InputActionsAssetReference : PersonalInputActions_JumpActionBase
{
    [SerializeField] private InputActionAsset inputActions;

    private InputAction jumpAction;

    private new void Awake()
    {
        base.Awake();

        jumpAction = inputActions.FindAction("Jump");
        jumpAction.performed += OnJumpAction;
        jumpAction.canceled += OnJumpAction;
        jumpAction.Enable();
    }

    private void OnDestroy()
    {
        jumpAction.performed -= OnJumpAction;
        jumpAction.canceled -= OnJumpAction;
        jumpAction.Disable();
    }

    private void Update()
    {
        HandleJumpAndGravity();
    }
}
