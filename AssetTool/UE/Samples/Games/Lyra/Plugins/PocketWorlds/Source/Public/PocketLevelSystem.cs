namespace AssetTool
{
    [JsonAsset("PocketLevelSubsystem")]
    public class UPocketLevelSubsystem : UWorldSubsystem
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}