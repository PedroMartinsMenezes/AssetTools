namespace AssetTool
{
    [JsonAsset("PinnedCommandListSettings")]
    public class UPinnedCommandListSettings : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}