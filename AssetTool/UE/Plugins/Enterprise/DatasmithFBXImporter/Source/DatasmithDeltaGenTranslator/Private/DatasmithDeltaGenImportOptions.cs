namespace AssetTool
{
    [JsonAsset("DatasmithDeltaGenImportOptions")]
    public class UDatasmithDeltaGenImportOptions : UDatasmithFBXImportOptions
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}