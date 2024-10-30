namespace AssetTool
{
    [JsonAsset("HierarchicalLODVolume")]
    public class AHierarchicalLODVolume : AVolume
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}