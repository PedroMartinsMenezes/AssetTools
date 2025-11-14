namespace AssetTool
{
    [JsonAsset("OptimusDebugDrawDataInterface")]
    public class UOptimusDebugDrawDataInterface : UOptimusComputeDataInterface
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("OptimusDebugDrawDataProvider")]
    public class UOptimusDebugDrawDataProvider : UComputeDataProvider
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}