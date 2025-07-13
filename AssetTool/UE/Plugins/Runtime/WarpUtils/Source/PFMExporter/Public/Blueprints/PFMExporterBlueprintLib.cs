namespace AssetTool
{
    [JsonAsset("PFMExporterBlueprintLib")]
    public class UPFMExporterBlueprintLib : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}