namespace AssetTool
{
    [JsonAsset("ReimportFbxSceneFactory")]
    public class UReimportFbxSceneFactory : UFbxSceneImportFactory
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}