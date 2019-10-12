using UnityEngine;

public class AICharacterController : ICharacterController
{
    public ICommand HandleInput()
    {
        //This is randomly selecting direction, change this to change how AI Characters work
        float xInput = Random.Range(-1.0f, 1.0f);
        float yInput = Random.Range(-1.0f, 1.0f);
        bool isJumping = Random.Range(-1.0f, 1.0f) > 0;

        if (xInput != 0 || isJumping)
            return new CharacterMoveCommand(xInput, yInput, isJumping);

        return null;
    }
}
