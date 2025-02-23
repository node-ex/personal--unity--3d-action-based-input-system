public class PersonalInputActions_GeneratedCSharpClass : PersonalInputActions_JumpActionBase
{
    private PersonalInputActions_Generated generatedInputActions;

    private new void Awake()
    {
        base.Awake();

        generatedInputActions = new PersonalInputActions_Generated();
        generatedInputActions.Player.Jump.performed += OnJumpAction;
        generatedInputActions.Player.Jump.canceled += OnJumpAction;
        generatedInputActions.Enable();
    }

    private void OnDestroy()
    {
        generatedInputActions.Player.Jump.performed -= OnJumpAction;
        generatedInputActions.Player.Jump.canceled -= OnJumpAction;
        generatedInputActions.Disable();
    }

    private void Update()
    {
        HandleJumpAndGravity();
    }
}
