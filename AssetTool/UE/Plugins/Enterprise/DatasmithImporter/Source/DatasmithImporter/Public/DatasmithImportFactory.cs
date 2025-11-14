namespace AssetTool
{
    [JsonAsset("DatasmithImportFactory")]
    public class UDatasmithImportFactory : USceneImportFactory
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}