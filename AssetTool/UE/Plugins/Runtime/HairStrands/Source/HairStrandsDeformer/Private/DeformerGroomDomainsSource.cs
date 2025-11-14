namespace AssetTool
{
    [JsonAsset("OptimusGroomAssetComponentSource")]
    public class UOptimusGroomAssetComponentSource : UOptimusComponentSource
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("OptimusGroomSolverComponentSource")]
    public class UOptimusGroomSolverComponentSource : UOptimusComponentSource
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}