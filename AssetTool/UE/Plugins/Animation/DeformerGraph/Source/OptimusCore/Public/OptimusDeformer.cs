namespace AssetTool
{
    [JsonAsset("OptimusComponentSourceBindingContainer")]
    public class UOptimusComponentSourceBindingContainer : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("OptimusVariableContainer")]
    public class UOptimusVariableContainer : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("OptimusResourceContainer")]
    public class UOptimusResourceContainer : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("OptimusDeformer")]
    public class UOptimusDeformer : UMeshDeformer
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}