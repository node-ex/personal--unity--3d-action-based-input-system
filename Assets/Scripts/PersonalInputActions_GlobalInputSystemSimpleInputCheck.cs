using UnityEngine.InputSystem;

public class PersonalInputActions_GlobalInputSystemSimpleInputCheck : PersonalInputActions_JumpActionBase
{
    private void Update()
    {
        Keyboard keyboard = InputSystem.GetDevice<Keyboard>();
        if (keyboard.spaceKey.wasPressedThisFrame)
        {
            OnJumpAction(InputActionChange.ActionPerformed);
        }
        else if (keyboard.spaceKey.wasReleasedThisFrame)
        {
            OnJumpAction(InputActionChange.ActionCanceled);
        }

        HandleJumpAndGravity();
    }
}
