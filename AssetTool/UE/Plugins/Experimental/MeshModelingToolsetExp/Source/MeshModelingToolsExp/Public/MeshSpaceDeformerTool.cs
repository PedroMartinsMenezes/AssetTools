namespace AssetTool
{
    [JsonAsset("MeshSpaceDeformerToolBuilder")]
    public class UMeshSpaceDeformerToolBuilder : USingleSelectionMeshEditingToolBuilder
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MeshSpaceDeformerToolProperties")]
    public class UMeshSpaceDeformerToolProperties : UInteractiveToolPropertySet
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MeshSpaceDeformerToolActionPropertySet")]
    public class UMeshSpaceDeformerToolActionPropertySet : UInteractiveToolPropertySet
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("SpaceDeformerOperatorFactory")]
    public class USpaceDeformerOperatorFactory : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MeshSpaceDeformerTool")]
    public class UMeshSpaceDeformerTool : USingleSelectionMeshEditingTool
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}