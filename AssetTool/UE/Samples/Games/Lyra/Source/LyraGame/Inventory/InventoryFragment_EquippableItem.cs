namespace AssetTool
{
    [JsonAsset("InventoryFragment_EquippableItem")]
    public class UInventoryFragment_EquippableItem : ULyraInventoryItemFragment
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}