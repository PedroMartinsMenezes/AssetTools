namespace AssetTool
{
    [JsonAsset("GLTFMaterialExportOptions")]
    public class UGLTFMaterialExportOptions : UAssetUserData
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}