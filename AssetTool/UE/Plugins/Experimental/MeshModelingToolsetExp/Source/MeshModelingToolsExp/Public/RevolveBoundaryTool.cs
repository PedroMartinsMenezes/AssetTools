namespace AssetTool
{
    [JsonAsset("RevolveBoundaryToolBuilder")]
    public class URevolveBoundaryToolBuilder : USingleSelectionMeshEditingToolBuilder
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("RevolveBoundaryOperatorFactory")]
    public class URevolveBoundaryOperatorFactory : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("RevolveBoundaryToolProperties")]
    public class URevolveBoundaryToolProperties : URevolveProperties
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("RevolveBoundaryTool")]
    public class URevolveBoundaryTool : UMeshBoundaryToolBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}