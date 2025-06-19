namespace AssetTool
{
    [JsonAsset("OptimusNode_CustomComputeKernel")]
    public class UOptimusNode_CustomComputeKernel : UOptimusNode_ComputeKernelBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}