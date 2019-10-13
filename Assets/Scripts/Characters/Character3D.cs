using UnityEngine;

[RequireComponent(typeof(CharacterController), typeof(MeshFilter), typeof(MeshCollider))]
[RequireComponent(typeof(MeshRenderer))]
public class Character3D : MonoBehaviour
{
    CharacterController characterController;

    [SerializeField] protected GameObject characterHead;

    protected ICharacterController characterController3D;

    [SerializeField] protected float lookSpeed = 30.0f;
    [SerializeField] protected float movementSpeed = 10.0f;
    [SerializeField] protected float jumpForce = 10.0f;

    [SerializeField] protected float gravity = 9.807f;

    Vector3 movementDirection = Vector3.zero;

    [SerializeField] protected bool invertVerticalLookDirection;

    protected virtual void Start()
    {
        characterController = GetComponent<CharacterController>();
        characterController.enableOverlapRecovery = true;
    }

    protected virtual void Update()
    {
        characterController3D.HandleInput(this);

        movementDirection.y -= gravity * Time.deltaTime;
        characterController.Move(movementDirection * Time.deltaTime);
    }

    public void Move(float xInput, float yInput, bool isJumping)
    {
        if (characterController.isGrounded)
        {
            movementDirection = new Vector3(xInput, 0.0f, yInput);
            movementDirection = transform.TransformDirection(movementDirection);
            movementDirection *= movementSpeed;

            if (isJumping)
                movementDirection.y = jumpForce;
        }
    }

    public void Look(float xInput, float yInput)
    {
        float verticalLookDelta = (yInput * lookSpeed) * Time.deltaTime;
        float horizontalLookDelta = (xInput * lookSpeed) * Time.deltaTime;

        float desiredVerticalLookDelta = (invertVerticalLookDirection) ? verticalLookDelta : -verticalLookDelta;

        transform.Rotate(new Vector3(0.0f, horizontalLookDelta, 0.0f));
        characterHead.transform.Rotate(new Vector3(desiredVerticalLookDelta, 0.0f, 0.0f));
    }
}
