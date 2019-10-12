public class CharacterMoveCommand : ICommand
{
    private float xInput;
    private float yInput;
    private bool isJumping;

    public CharacterMoveCommand(float _xInput, float _yInput, bool _isJumping)
    {
        xInput = _xInput;
        yInput = _yInput;
        isJumping = _isJumping;
    }

    public void Execute(Character3D character)
    {
        character.Move(xInput, yInput, isJumping);
    }
}
