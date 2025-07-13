namespace AssetTool
{
    [JsonAsset("NegatableFilter")]
    public class UNegatableFilter : ULevelSnapshotFilter
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}