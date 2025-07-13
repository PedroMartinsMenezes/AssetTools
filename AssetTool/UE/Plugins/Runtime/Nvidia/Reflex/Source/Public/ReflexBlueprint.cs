namespace AssetTool
{
    [JsonAsset("ReflexBlueprintLibrary")]
    public class UReflexBlueprintLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}