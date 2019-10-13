public class AICharacter : Character3D
{
    protected override void Start()
    {
        base.Start();
        characterController3D = new AIController();
    }

    protected override void Update()
    {
        base.Update();
    }
}
