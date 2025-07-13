namespace AssetTool
{
    [JsonAsset("PluginBlueprintLibrary")]
    public class UPluginBlueprintLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}