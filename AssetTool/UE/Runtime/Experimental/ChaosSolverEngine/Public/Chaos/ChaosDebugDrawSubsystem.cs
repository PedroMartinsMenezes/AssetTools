namespace AssetTool
{
    [JsonAsset("ChaosDebugDrawSubsystem")]
    public class UChaosDebugDrawSubsystem : UWorldSubsystem
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}