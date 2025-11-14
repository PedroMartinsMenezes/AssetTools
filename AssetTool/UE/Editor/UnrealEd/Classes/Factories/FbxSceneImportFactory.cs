namespace AssetTool
{
    [JsonAsset("FbxSceneImportFactory")]
    public class UFbxSceneImportFactory : USceneImportFactory
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}