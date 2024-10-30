namespace AssetTool
{
    [JsonAsset("FbxAnimSequenceImportData")]
    public class UFbxAnimSequenceImportData : UFbxAssetImportData
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}