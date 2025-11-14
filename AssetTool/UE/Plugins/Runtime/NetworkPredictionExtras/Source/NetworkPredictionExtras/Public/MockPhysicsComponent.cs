namespace AssetTool
{
    [JsonAsset("MockPhysicsComponent")]
    public class UMockPhysicsComponent : UBaseMovementComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}