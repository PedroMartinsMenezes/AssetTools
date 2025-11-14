namespace AssetTool
{
    [JsonAsset("SpotLightImportTestFunctions")]
    public class USpotLightImportTestFunctions : UPointLightImportTestFunctions
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}