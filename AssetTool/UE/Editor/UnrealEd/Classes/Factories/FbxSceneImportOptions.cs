namespace AssetTool
{
    [JsonAsset("FbxSceneImportOptions")]
    public class UFbxSceneImportOptions : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}