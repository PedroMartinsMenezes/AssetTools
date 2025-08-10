namespace AssetTool
{
    [JsonAsset("DNAImporterLibrary")]
    public class UDNAImporterLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}