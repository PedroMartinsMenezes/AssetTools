namespace AssetTool
{
    [JsonAsset("AssetDefinition_SparseVolumeTexture")]
    public class UAssetDefinition_SparseVolumeTexture : UAssetDefinitionDefault
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("AssetDefinition_StaticSparseVolumeTexture")]
    public class UAssetDefinition_StaticSparseVolumeTexture : UAssetDefinition_SparseVolumeTexture
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("AssetDefinition_AnimatedSparseVolumeTexture")]
    public class UAssetDefinition_AnimatedSparseVolumeTexture : UAssetDefinition_SparseVolumeTexture
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}