using UnityEngine;

public class AIController : ICharacterController
{
    public void HandleInput(Character3D character)
    {
        //This is randomly selecting direction, change this to change how AI Characters work
        float xInput = Random.Range(-1.0f, 1.0f);
        float yInput = Random.Range(-1.0f, 1.0f);
        bool isJumping = Random.Range(-1.0f, 1.0f) > 0;

        character.Move(xInput, yInput, isJumping);
    }
}
