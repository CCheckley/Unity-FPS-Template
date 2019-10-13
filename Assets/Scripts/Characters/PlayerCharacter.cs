public class PlayerCharacter : Character3D
{
    protected override void Start()
    {
        base.Start();
        characterController3D = new PlayerController();
    }

    protected override void Update()
    {
        base.Update();
    }
}
