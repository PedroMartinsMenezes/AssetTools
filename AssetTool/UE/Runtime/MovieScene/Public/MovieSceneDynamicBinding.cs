namespace AssetTool
{
    [JsonAsset("BuiltInDynamicBindingResolverLibrary")]
    public class UBuiltInDynamicBindingResolverLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}