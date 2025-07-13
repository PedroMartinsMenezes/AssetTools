namespace AssetTool
{
    [JsonAsset("AssetImportTestFunctions")]
    public class UAssetImportTestFunctions : UImportTestFunctionsBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}