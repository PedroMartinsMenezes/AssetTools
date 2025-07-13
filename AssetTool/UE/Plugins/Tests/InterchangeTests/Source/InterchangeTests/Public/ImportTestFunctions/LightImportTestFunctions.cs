namespace AssetTool
{
    [JsonAsset("LightImportTestFunctions")]
    public class ULightImportTestFunctions : UActorImportTestFunctions
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}