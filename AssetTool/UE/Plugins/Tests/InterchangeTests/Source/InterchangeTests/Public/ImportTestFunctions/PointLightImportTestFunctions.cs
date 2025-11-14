namespace AssetTool
{
    [JsonAsset("PointLightImportTestFunctions")]
    public class UPointLightImportTestFunctions : ULightImportTestFunctions
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}