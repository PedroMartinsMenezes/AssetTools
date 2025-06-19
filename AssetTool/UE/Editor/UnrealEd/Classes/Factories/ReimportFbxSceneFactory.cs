namespace AssetTool
{
    [JsonAsset("ReimportFbxSceneFactory")]
    public class UReimportFbxSceneFactory : UFbxSceneImportFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}