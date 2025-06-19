namespace AssetTool
{
    [JsonAsset("HierarchicalLODVolume")]
    public class AHierarchicalLODVolume : AVolume
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}