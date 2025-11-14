namespace AssetTool
{
    [JsonAsset("InventoryFragment_SetStats")]
    public class UInventoryFragment_SetStats : ULyraInventoryItemFragment
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}