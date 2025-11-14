namespace AssetTool
{
    [JsonAsset("GLTFMaterialExportOptions")]
    public class UGLTFMaterialExportOptions : UAssetUserData
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}