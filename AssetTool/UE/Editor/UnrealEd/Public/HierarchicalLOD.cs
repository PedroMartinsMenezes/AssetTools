namespace AssetTool
{
    [JsonAsset("HierarchicalLODSettings")]
    public class UHierarchicalLODSettings : UDeveloperSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}