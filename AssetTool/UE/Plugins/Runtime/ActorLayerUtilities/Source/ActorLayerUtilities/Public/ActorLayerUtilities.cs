namespace AssetTool
{
    [JsonAsset("LayersBlueprintLibrary")]
    public class ULayersBlueprintLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}