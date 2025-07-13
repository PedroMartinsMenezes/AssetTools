namespace AssetTool
{
    [JsonAsset("ImportTestFunctionsBase")]
    public class UImportTestFunctionsBase : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}