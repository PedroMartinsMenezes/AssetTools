namespace AssetTool
{
    [JsonAsset("ReimportFbxSceneFactory")]
    public class UReimportFbxSceneFactory : UFbxSceneImportFactory
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}