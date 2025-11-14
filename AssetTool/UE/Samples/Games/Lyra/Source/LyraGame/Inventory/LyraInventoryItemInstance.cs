namespace AssetTool
{
    [JsonAsset("LyraInventoryItemInstance")]
    public class ULyraInventoryItemInstance : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}