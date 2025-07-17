namespace AssetTool
{
    [JsonAsset("LyraAbilityCost_InventoryItem")]
    public class ULyraAbilityCost_InventoryItem : ULyraAbilityCost
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}