namespace AssetTool
{
    [JsonAsset("MeshVertexColorPaintingToolBuilder")]
    public class UMeshVertexColorPaintingToolBuilder : UInteractiveToolBuilder
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MeshVertexWeightPaintingToolBuilder")]
    public class UMeshVertexWeightPaintingToolBuilder : UInteractiveToolBuilder
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MeshVertexPaintingToolProperties")]
    public class UMeshVertexPaintingToolProperties : UMeshPaintingToolProperties
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MeshVertexColorPaintingToolProperties")]
    public class UMeshVertexColorPaintingToolProperties : UMeshVertexPaintingToolProperties
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MeshVertexWeightPaintingToolProperties")]
    public class UMeshVertexWeightPaintingToolProperties : UMeshVertexPaintingToolProperties
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MeshVertexPaintingTool")]
    public class UMeshVertexPaintingTool : UBaseBrushTool
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MeshVertexColorPaintingTool")]
    public class UMeshVertexColorPaintingTool : UMeshVertexPaintingTool
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MeshVertexWeightPaintingTool")]
    public class UMeshVertexWeightPaintingTool : UMeshVertexPaintingTool
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}