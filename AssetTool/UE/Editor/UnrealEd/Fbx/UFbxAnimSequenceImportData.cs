namespace AssetTool
{
    [JsonAsset("FbxAnimSequenceImportData")]
    public class UFbxAnimSequenceImportData : UFbxAssetImportData
    {
        [Location("UFbxAnimSequenceImportData::Serialize(FArchive& Ar)")]
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
