namespace AssetTool
{
    [JsonAsset("LambdaFilter")]
    public class ULambdaFilter : ULevelSnapshotFilter
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}