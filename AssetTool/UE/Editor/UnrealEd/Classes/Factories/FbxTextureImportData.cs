namespace AssetTool
{
    [JsonAsset("FbxTextureImportData")]
    public class UFbxTextureImportData : UFbxAssetImportData
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}