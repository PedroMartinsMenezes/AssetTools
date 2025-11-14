namespace AssetTool
{
    [JsonAsset("VCamBlueprintFunctionLibrary")]
    public class UVCamBlueprintFunctionLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}