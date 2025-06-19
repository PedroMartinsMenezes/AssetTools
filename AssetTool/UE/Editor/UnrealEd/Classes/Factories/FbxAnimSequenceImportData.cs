namespace AssetTool
{
    [JsonAsset("FbxAnimSequenceImportData")]
    public class UFbxAnimSequenceImportData : UFbxAssetImportData
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}