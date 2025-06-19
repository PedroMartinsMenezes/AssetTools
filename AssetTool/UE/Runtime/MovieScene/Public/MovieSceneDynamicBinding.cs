namespace AssetTool
{
    [JsonAsset("BuiltInDynamicBindingResolverLibrary")]
    public class UBuiltInDynamicBindingResolverLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}