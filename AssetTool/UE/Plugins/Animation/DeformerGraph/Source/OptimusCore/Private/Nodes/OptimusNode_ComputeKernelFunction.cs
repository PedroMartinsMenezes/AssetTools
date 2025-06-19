namespace AssetTool
{
    [JsonAsset("OptimusNode_ComputeKernelFunctionGeneratorClass")]
    public class UOptimusNode_ComputeKernelFunctionGeneratorClass : UClass
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("OptimusNode_ComputeKernelFunction")]
    public class UOptimusNode_ComputeKernelFunction : UOptimusNode_ComputeKernelBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}