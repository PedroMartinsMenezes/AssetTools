namespace AssetTool
{
    [JsonAsset("PhysicsJumpCheck")]
    public class UPhysicsJumpCheck : UBaseMovementModeTransition
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}