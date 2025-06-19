namespace AssetTool
{
    [JsonAsset("PCGBlueprintHelpers")]
    public class UPCGBlueprintHelpers : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}