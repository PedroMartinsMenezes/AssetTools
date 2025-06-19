namespace AssetTool
{
    [JsonAsset("FbxSceneImportData")]
    public class UFbxSceneImportData : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}