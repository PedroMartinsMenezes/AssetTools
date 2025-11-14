namespace AssetTool
{
    [JsonAsset("AssetImportTestFunctions")]
    public class UAssetImportTestFunctions : UImportTestFunctionsBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}