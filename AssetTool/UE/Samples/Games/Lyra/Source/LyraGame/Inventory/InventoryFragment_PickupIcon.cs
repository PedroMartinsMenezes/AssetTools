namespace AssetTool
{
    [JsonAsset("InventoryFragment_PickupIcon")]
    public class UInventoryFragment_PickupIcon : ULyraInventoryItemFragment
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}