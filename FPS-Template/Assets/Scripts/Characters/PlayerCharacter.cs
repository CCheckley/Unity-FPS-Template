public class PlayerCharacter : Character3D
{
    protected override void Start()
    {
        base.Start();
        characterController3D = new PlayerCharacterController();
    }

    protected override void Update()
    {
        base.Update();
    }
}
