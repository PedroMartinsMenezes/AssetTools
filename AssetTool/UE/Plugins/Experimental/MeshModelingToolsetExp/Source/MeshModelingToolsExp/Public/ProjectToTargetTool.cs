namespace AssetTool
{
    [JsonAsset("ProjectToTargetToolBuilder")]
    public class UProjectToTargetToolBuilder : UMultiSelectionMeshEditingToolBuilder
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ProjectToTargetToolProperties")]
    public class UProjectToTargetToolProperties : URemeshMeshToolProperties
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ProjectToTargetTool")]
    public class UProjectToTargetTool : URemeshMeshTool
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}