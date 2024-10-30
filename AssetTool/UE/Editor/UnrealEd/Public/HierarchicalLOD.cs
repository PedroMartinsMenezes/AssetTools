namespace AssetTool
{
    [JsonAsset("HierarchicalLODSettings")]
    public class UHierarchicalLODSettings : UDeveloperSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}