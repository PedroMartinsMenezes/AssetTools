namespace AssetTool
{
    [JsonAsset("StormSyncImportSubsystem")]
    public class UStormSyncImportSubsystem : UEngineSubsystem
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}