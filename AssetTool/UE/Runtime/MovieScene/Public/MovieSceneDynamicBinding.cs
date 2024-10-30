namespace AssetTool
{
    [JsonAsset("BuiltInDynamicBindingResolverLibrary")]
    public class UBuiltInDynamicBindingResolverLibrary : UBlueprintFunctionLibrary
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}