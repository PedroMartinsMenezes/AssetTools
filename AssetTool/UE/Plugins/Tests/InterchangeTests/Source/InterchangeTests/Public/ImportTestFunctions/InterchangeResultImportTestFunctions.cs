namespace AssetTool
{
    [JsonAsset("InterchangeResultImportTestFunctions")]
    public class UInterchangeResultImportTestFunctions : UImportTestFunctionsBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}