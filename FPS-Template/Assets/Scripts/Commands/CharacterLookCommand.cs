public class CharacterLookCommand : ICommand
{
    private float xInput;
    private float yInput;

    public CharacterLookCommand(float _xInput, float _yInput)
    {
        xInput = _xInput;
        yInput = _yInput;
    }

    public void Execute(Character3D character)
    {
        character.Look(xInput, yInput);
    }
}
