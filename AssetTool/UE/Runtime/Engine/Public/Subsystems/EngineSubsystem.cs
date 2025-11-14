namespace AssetTool
{
    [JsonAsset("EngineSubsystem")]
    public class UEngineSubsystem : UDynamicSubsystem
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}