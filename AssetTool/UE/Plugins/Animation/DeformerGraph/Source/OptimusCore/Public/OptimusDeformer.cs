namespace AssetTool
{
    [JsonAsset("OptimusComponentSourceBindingContainer")]
    public class UOptimusComponentSourceBindingContainer : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("OptimusVariableContainer")]
    public class UOptimusVariableContainer : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("OptimusResourceContainer")]
    public class UOptimusResourceContainer : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("OptimusDeformer")]
    public class UOptimusDeformer : UMeshDeformer
    {
        public int[] ResourcesPerKernel;

        [Location("void UOptimusDeformer::Serialize(FArchive& Ar)")]
        public override ITransferible Move(Transfer transfer)
        {
            base.Move(transfer);
            if (!transfer.Supports.SwitchToMeshDeformerBase)
            {
                transfer.Move(ref ResourcesPerKernel);
            }
            return this;
        }
    }
}