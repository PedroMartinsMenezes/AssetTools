namespace AssetTool
{
    [JsonAsset("StormSyncImportWorldSubsystem")]
    public class UStormSyncImportWorldSubsystem : UWorldSubsystem
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}