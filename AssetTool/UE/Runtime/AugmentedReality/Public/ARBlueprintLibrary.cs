namespace AssetTool
{
    [JsonAsset("ARBlueprintLibrary")]
    public class UARBlueprintLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ARTraceResultLibrary")]
    public class UARTraceResultLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}