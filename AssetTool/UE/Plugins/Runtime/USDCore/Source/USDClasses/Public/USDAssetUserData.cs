namespace AssetTool
{
    [JsonAsset("UsdAssetUserData")]
    public class UUsdAssetUserData : UAssetUserData
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("UsdAnimSequenceAssetUserData")]
    public class UUsdAnimSequenceAssetUserData : UUsdAssetUserData
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("UsdMaterialAssetUserData")]
    public class UUsdMaterialAssetUserData : UUsdAssetUserData
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("UsdMeshAssetUserData")]
    public class UUsdMeshAssetUserData : UUsdAssetUserData
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("UsdGeometryCacheAssetUserData")]
    public class UUsdGeometryCacheAssetUserData : UUsdMeshAssetUserData
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("UsdSparseVolumeTextureAssetUserData")]
    public class UUsdSparseVolumeTextureAssetUserData : UUsdAssetUserData
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}