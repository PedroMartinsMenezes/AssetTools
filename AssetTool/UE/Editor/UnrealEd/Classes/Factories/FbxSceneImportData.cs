namespace AssetTool
{
    [JsonAsset("FbxSceneImportData")]
    public class UFbxSceneImportData : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}