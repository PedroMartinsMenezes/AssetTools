namespace AssetTool
{
    [JsonAsset("GenerateLODMeshesToolBuilder")]
    public class UGenerateLODMeshesToolBuilder : USingleSelectionMeshEditingToolBuilder
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("GenerateLODMeshesToolProperties")]
    public class UGenerateLODMeshesToolProperties : UMeshConstraintProperties
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("GenerateLODMeshesTool")]
    public class UGenerateLODMeshesTool : USingleSelectionMeshEditingTool
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}