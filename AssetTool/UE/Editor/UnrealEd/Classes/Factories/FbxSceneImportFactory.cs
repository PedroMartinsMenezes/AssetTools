namespace AssetTool
{
    [JsonAsset("FbxSceneImportFactory")]
    public class UFbxSceneImportFactory : USceneImportFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}