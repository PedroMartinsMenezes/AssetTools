namespace AssetTool
{
    [JsonAsset("DatasmithImportFactory")]
    public class UDatasmithImportFactory : USceneImportFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}