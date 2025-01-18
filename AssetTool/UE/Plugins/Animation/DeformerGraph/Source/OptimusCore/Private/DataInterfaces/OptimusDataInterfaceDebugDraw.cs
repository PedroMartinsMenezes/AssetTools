namespace AssetTool
{
    [JsonAsset("OptimusDebugDrawDataInterface")]
    public class UOptimusDebugDrawDataInterface : UOptimusComputeDataInterface
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("OptimusDebugDrawDataProvider")]
    public class UOptimusDebugDrawDataProvider : UComputeDataProvider
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}