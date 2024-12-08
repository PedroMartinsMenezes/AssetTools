namespace AssetTool
{
    [JsonAsset("HierarchicalLODSetup")]
    public class UHierarchicalLODSetup : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("WorldSettings")]
    public class AWorldSettings : AInfo
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}