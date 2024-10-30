namespace AssetTool
{
    [JsonAsset("FbxSceneImportFactory")]
    public class UFbxSceneImportFactory : USceneImportFactory
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}