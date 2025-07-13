namespace AssetTool
{
    [JsonAsset("SpotLightImportTestFunctions")]
    public class USpotLightImportTestFunctions : UPointLightImportTestFunctions
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}