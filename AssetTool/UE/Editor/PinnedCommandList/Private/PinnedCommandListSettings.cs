namespace AssetTool
{
    [JsonAsset("PinnedCommandListSettings")]
    public class UPinnedCommandListSettings : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}