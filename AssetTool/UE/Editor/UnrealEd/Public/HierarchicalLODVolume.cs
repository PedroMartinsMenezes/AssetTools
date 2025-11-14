namespace AssetTool
{
    [JsonAsset("HierarchicalLODVolume")]
    public class AHierarchicalLODVolume : AVolume
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}