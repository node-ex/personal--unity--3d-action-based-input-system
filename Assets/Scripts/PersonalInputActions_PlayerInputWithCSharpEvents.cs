using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(PlayerInput))]
public class PersonalInputActions_PlayerInputWithCSharpEvents : PersonalInputActions_JumpActionBase
{
    private PlayerInput _playerInput;

    private new void Awake()
    {
        base.Awake();

        _playerInput = GetComponent<PlayerInput>();

        _playerInput.onActionTriggered += OnActionTriggered;
    }

    private void OnDestroy()
    {
        _playerInput.onActionTriggered -= OnActionTriggered;
    }

    private void Update()
    {
        HandleJumpAndGravity();
    }

    private void OnActionTriggered(InputAction.CallbackContext context)
    {
        if (context.action.name == "Jump")
        {
            OnJumpAction(context);
        }
    }
}
