using UnityEngine;

public class PlayerCharacterController : ICharacterController
{
    public ICommand HandleInput()
    {
        float mouseX = Input.GetAxisRaw("Mouse X");
        float mouseY = Input.GetAxisRaw("Mouse Y");

        float MoveRight = Input.GetAxisRaw("Horizontal");
        float MoveForward = Input.GetAxisRaw("Vertical");

        bool isJumping = Input.GetButtonDown("Jump");

        if (MoveRight != 0 || MoveForward != 0 || isJumping)
            return new CharacterMoveCommand(MoveRight, MoveForward, isJumping);

        if (mouseX != 0 || mouseY != 0)
            return new CharacterLookCommand(mouseX, mouseY);

        return null;
    }
}
