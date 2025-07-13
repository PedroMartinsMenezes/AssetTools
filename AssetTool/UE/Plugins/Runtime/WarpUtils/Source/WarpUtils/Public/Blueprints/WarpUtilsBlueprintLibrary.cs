namespace AssetTool
{
    [JsonAsset("WarpUtilsBlueprintLibrary")]
    public class UWarpUtilsBlueprintLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}