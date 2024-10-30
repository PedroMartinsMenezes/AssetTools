namespace AssetTool
{
    [JsonAsset("EngineSubsystem")]
    public class UEngineSubsystem : UDynamicSubsystem
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}