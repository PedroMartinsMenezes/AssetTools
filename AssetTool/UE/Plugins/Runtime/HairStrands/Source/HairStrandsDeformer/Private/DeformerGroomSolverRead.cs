namespace AssetTool
{
    [JsonAsset("OptimusGroomSolverReadDataInterface")]
    public class UOptimusGroomSolverReadDataInterface : UOptimusComputeDataInterface
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("OptimusGroomSolverReadDataProvider")]
    public class UOptimusGroomSolverReadDataProvider : UComputeDataProvider
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}