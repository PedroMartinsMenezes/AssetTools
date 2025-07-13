namespace AssetTool
{
    [JsonAsset("DatasmithVREDImportOptions")]
    public class UDatasmithVREDImportOptions : UDatasmithFBXImportOptions
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}