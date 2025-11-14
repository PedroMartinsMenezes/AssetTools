namespace AssetTool
{
    [JsonAsset("DatasmithVREDImportOptions")]
    public class UDatasmithVREDImportOptions : UDatasmithFBXImportOptions
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}