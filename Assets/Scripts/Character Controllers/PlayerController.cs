using UnityEngine;

public class PlayerController : ICharacterController
{
    public void HandleInput(Character3D character)
    {
        float mouseX = Input.GetAxisRaw("Mouse X");
        float mouseY = Input.GetAxisRaw("Mouse Y");

        float MoveRight = Input.GetAxisRaw("Horizontal");
        float MoveForward = Input.GetAxisRaw("Vertical");

        bool isJumping = Input.GetButtonDown("Jump");

        character.Move(MoveRight, MoveForward, isJumping);
        character.Look(mouseX, mouseY);
    }
}
