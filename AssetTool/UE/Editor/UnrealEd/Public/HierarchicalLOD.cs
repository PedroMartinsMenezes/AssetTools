namespace AssetTool
{
    [JsonAsset("HierarchicalLODSettings")]
    public class UHierarchicalLODSettings : UDeveloperSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}