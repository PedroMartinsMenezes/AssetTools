namespace AssetTool
{
    [JsonAsset("LightImportTestFunctions")]
    public class ULightImportTestFunctions : UActorImportTestFunctions
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}