using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(CharacterController))]
public class PersonalInputActions_JumpActionBase : MonoBehaviour
{
    [SerializeField] protected float jumpForce = 5f;
    [SerializeField] protected float gravity = -9.81f;

    private CharacterController _characterController;
    private bool _jumpPressed;
    private Vector3 _verticalVelocity;

    protected void Awake()
    {
        _characterController = GetComponent<CharacterController>();
    }

    protected void HandleJumpAndGravity()
    {
        if (_characterController.isGrounded)
        {
            _verticalVelocity.y = -0.5f; // Small downward force to stay grounded
            if (_jumpPressed)
            {
                _verticalVelocity.y = Mathf.Sqrt(jumpForce * -2f * gravity);
            }
        }

        _verticalVelocity.y += gravity * Time.deltaTime;
        _characterController.Move(_verticalVelocity * Time.deltaTime);
    }

    protected void OnJumpAction(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Performed)
        {
            _jumpPressed = true;
        }
        else if (context.phase == InputActionPhase.Canceled)
        {
            _jumpPressed = false;
        }
    }

    protected void OnJumpAction(InputActionChange change)
    {
        if (change == InputActionChange.ActionPerformed)
        {
            _jumpPressed = true;
        }
        else if (change == InputActionChange.ActionCanceled)
        {
            _jumpPressed = false;
        }
    }
}
