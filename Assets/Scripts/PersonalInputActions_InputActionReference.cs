using UnityEngine;
using UnityEngine.InputSystem;

public class PersonalInputActions_InputActionReference : PersonalInputActions_JumpActionBase
{
    [SerializeField] private InputActionReference jumpAction;

    private new void Awake()
    {
        base.Awake();

        jumpAction.action.performed += OnJumpAction;
        jumpAction.action.canceled += OnJumpAction;
        jumpAction.action.Enable();
    }

    private void OnDestroy()
    {
        jumpAction.action.performed -= OnJumpAction;
        jumpAction.action.canceled -= OnJumpAction;
        jumpAction.action.Disable();
    }

    private void Update()
    {
        HandleJumpAndGravity();
    }
}
