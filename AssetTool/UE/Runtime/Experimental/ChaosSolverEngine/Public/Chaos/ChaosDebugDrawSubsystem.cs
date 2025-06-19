namespace AssetTool
{
    [JsonAsset("ChaosDebugDrawSubsystem")]
    public class UChaosDebugDrawSubsystem : UWorldSubsystem
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}