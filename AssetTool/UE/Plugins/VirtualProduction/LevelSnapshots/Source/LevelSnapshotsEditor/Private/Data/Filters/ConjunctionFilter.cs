namespace AssetTool
{
    [JsonAsset("ConjunctionFilter")]
    public class UConjunctionFilter : ULevelSnapshotFilter
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}