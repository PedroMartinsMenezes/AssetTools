namespace AssetTool
{
    [JsonAsset("MockRootMotionComponent")]
    public class UMockRootMotionComponent : UBaseMovementComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}