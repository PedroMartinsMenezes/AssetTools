namespace AssetTool
{
    [JsonAsset("ReflexBlueprintLibrary")]
    public class UReflexBlueprintLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}