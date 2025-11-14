namespace AssetTool
{
    [JsonAsset("FbxAnimSequenceImportData")]
    public class UFbxAnimSequenceImportData : UFbxAssetImportData
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}