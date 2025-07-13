namespace AssetTool
{
    [JsonAsset("MockRootMotionComponent")]
    public class UMockRootMotionComponent : UBaseMovementComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}