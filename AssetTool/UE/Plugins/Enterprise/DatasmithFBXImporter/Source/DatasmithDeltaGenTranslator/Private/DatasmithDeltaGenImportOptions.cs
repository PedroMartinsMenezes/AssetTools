namespace AssetTool
{
    [JsonAsset("DatasmithDeltaGenImportOptions")]
    public class UDatasmithDeltaGenImportOptions : UDatasmithFBXImportOptions
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}