namespace AssetTool
{
    [JsonAsset("InventoryFragment_QuickBarIcon")]
    public class UInventoryFragment_QuickBarIcon : ULyraInventoryItemFragment
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}