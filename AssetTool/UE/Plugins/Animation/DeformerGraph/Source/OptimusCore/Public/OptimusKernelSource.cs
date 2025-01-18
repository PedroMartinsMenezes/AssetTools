namespace AssetTool
{
    [JsonAsset("OptimusKernelSource")]
    public class UOptimusKernelSource : UComputeKernelSource
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}