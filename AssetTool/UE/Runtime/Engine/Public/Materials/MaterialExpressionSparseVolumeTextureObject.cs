namespace AssetTool
{
    [JsonAsset("MaterialExpressionSparseVolumeTextureObject")]
    public class UMaterialExpressionSparseVolumeTextureObject : UMaterialExpressionSparseVolumeTextureBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MaterialExpressionSparseVolumeTextureObjectParameter")]
    public class UMaterialExpressionSparseVolumeTextureObjectParameter : UMaterialExpressionSparseVolumeTextureSampleParameter
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}