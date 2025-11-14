namespace AssetTool
{
    [JsonAsset("LandmassBlueprintFunctionLibrary")]
    public class ULandmassBlueprintFunctionLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}