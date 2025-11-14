namespace AssetTool
{
    [JsonAsset("InventoryFragment_ReticleConfig")]
    public class UInventoryFragment_ReticleConfig : ULyraInventoryItemFragment
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}