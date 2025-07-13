namespace AssetTool
{
    [JsonAsset("SubobjectDataSubsystem")]
    public class USubobjectDataSubsystem : UEngineSubsystem
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}