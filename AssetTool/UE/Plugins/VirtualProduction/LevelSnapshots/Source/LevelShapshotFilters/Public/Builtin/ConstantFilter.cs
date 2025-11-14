namespace AssetTool
{
    [JsonAsset("ConstantFilter")]
    public class UConstantFilter : ULevelSnapshotFilter
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}