namespace AssetTool
{
    [JsonAsset("ImportTestFunctionsBase")]
    public class UImportTestFunctionsBase : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}