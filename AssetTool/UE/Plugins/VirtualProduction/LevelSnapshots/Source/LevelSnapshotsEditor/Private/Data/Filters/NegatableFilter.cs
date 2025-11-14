namespace AssetTool
{
    [JsonAsset("NegatableFilter")]
    public class UNegatableFilter : ULevelSnapshotFilter
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}