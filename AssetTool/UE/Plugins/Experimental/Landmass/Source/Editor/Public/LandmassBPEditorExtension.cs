namespace AssetTool
{
    [JsonAsset("LandmassBlueprintFunctionLibrary")]
    public class ULandmassBlueprintFunctionLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}