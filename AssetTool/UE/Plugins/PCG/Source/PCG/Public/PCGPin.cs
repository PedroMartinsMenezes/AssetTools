namespace AssetTool
{
    [JsonAsset("PCGBlueprintPinHelpers")]
    public class UPCGBlueprintPinHelpers : UBlueprintFunctionLibrary
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PCGPin")]
    public class UPCGPin : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PCGPinPropertiesBlueprintHelpers")]
    public class UPCGPinPropertiesBlueprintHelpers : UBlueprintFunctionLibrary
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}