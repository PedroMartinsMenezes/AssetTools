namespace AssetTool
{
    [JsonAsset("OptimusKernelSource")]
    public class UOptimusKernelSource : UComputeKernelSource
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}