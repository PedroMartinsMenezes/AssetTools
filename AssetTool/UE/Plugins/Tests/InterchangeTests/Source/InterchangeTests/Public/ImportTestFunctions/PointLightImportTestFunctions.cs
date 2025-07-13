namespace AssetTool
{
    [JsonAsset("PointLightImportTestFunctions")]
    public class UPointLightImportTestFunctions : ULightImportTestFunctions
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}