namespace AssetTool
{
    [JsonAsset("LyraInventoryItemInstance")]
    public class ULyraInventoryItemInstance : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}