namespace AssetTool
{
    [JsonAsset("LambdaFilter")]
    public class ULambdaFilter : ULevelSnapshotFilter
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}