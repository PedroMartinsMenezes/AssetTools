namespace AssetTool
{
    [JsonAsset("OptimusGroomAssetComponentSource")]
    public class UOptimusGroomAssetComponentSource : UOptimusComponentSource
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("OptimusGroomSolverComponentSource")]
    public class UOptimusGroomSolverComponentSource : UOptimusComponentSource
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}