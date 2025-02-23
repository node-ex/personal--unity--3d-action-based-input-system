using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(PlayerInput))]
public class PersonalInputActions_PlayerInputWithUnityEvents : PersonalInputActions_JumpActionBase
{
    public new void OnJumpAction(InputAction.CallbackContext context)
    {
        base.OnJumpAction(context);
    }

    private void Update()
    {
        HandleJumpAndGravity();
    }
}
