namespace AssetTool
{
    [JsonAsset("VertexAdapterClickToolBuilder")]
    public class UVertexAdapterClickToolBuilder : USingleClickToolBuilder
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("TextureColorAdapterClickToolBuilder")]
    public class UTextureColorAdapterClickToolBuilder : USingleClickToolBuilder
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("TextureAssetAdapterClickToolBuilder")]
    public class UTextureAssetAdapterClickToolBuilder : USingleClickToolBuilder
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MeshClickTool")]
    public class UMeshClickTool : USingleClickTool
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("VertexAdapterClickTool")]
    public class UVertexAdapterClickTool : UMeshClickTool
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("TextureColorAdapterClickTool")]
    public class UTextureColorAdapterClickTool : UMeshClickTool
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("TextureAssetAdapterClickTool")]
    public class UTextureAssetAdapterClickTool : UMeshClickTool
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}