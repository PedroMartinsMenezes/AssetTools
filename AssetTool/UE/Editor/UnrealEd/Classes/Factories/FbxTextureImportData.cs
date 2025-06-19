namespace AssetTool
{
    [JsonAsset("FbxTextureImportData")]
    public class UFbxTextureImportData : UFbxAssetImportData
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}