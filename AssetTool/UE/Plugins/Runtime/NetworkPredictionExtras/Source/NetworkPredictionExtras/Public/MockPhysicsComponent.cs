namespace AssetTool
{
    [JsonAsset("MockPhysicsComponent")]
    public class UMockPhysicsComponent : UBaseMovementComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}