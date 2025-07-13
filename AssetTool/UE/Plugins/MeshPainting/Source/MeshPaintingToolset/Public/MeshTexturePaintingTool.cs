namespace AssetTool
{
    [JsonAsset("MeshTextureColorPaintingToolBuilder")]
    public class UMeshTextureColorPaintingToolBuilder : UInteractiveToolBuilder
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MeshTextureAssetPaintingToolBuilder")]
    public class UMeshTextureAssetPaintingToolBuilder : UInteractiveToolBuilder
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MeshTexturePaintingToolProperties")]
    public class UMeshTexturePaintingToolProperties : UMeshPaintingToolProperties
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MeshTextureColorPaintingToolProperties")]
    public class UMeshTextureColorPaintingToolProperties : UMeshTexturePaintingToolProperties
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MeshTextureAssetPaintingToolProperties")]
    public class UMeshTextureAssetPaintingToolProperties : UMeshTexturePaintingToolProperties
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MeshTexturePaintingTool")]
    public class UMeshTexturePaintingTool : UBaseBrushTool
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MeshTextureColorPaintingTool")]
    public class UMeshTextureColorPaintingTool : UMeshTexturePaintingTool
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MeshTextureAssetPaintingTool")]
    public class UMeshTextureAssetPaintingTool : UMeshTexturePaintingTool
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}