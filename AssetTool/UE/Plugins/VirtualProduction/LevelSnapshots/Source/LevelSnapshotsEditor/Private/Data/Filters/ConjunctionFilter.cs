namespace AssetTool
{
    [JsonAsset("ConjunctionFilter")]
    public class UConjunctionFilter : ULevelSnapshotFilter
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}