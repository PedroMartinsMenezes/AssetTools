namespace AssetTool
{
    [JsonAsset("PocketLevelSubsystem")]
    public class UPocketLevelSubsystem : UWorldSubsystem
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}