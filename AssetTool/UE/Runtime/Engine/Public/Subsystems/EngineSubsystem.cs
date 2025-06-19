namespace AssetTool
{
    [JsonAsset("EngineSubsystem")]
    public class UEngineSubsystem : UDynamicSubsystem
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}