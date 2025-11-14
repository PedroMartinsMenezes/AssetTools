namespace AssetTool
{
    [JsonAsset("PluginBlueprintLibrary")]
    public class UPluginBlueprintLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}