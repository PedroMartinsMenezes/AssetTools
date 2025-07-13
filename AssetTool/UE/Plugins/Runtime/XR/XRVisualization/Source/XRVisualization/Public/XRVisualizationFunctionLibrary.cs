namespace AssetTool
{
    [JsonAsset("XRVisualizationLoadHelper")]
    public class UXRVisualizationLoadHelper : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("XRVisualizationFunctionLibrary")]
    public class UXRVisualizationFunctionLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}