using UnityEngine.InputSystem;

public class PersonalInputActions_GlobalInputSystemOnActionChange : PersonalInputActions_JumpActionBase
{
    private new void Awake()
    {
        base.Awake();

        InputSystem.onActionChange += OnActionTriggered;
    }

    private void OnDestroy()
    {
        InputSystem.onActionChange -= OnActionTriggered;
    }

    private void Update()
    {
        HandleJumpAndGravity();
    }

    void OnActionTriggered(object obj, InputActionChange change)
    {
        if (obj is InputAction action && action.name == "Jump")
        {
            OnJumpAction(change);
        }
    }
}
