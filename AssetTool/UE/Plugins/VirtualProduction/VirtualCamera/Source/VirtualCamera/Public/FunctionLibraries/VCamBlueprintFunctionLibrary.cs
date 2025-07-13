namespace AssetTool
{
    [JsonAsset("VCamBlueprintFunctionLibrary")]
    public class UVCamBlueprintFunctionLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}