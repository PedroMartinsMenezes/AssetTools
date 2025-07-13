namespace AssetTool
{
    [JsonAsset("VCamUIFunctionLibrary")]
    public class UVCamUIFunctionLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}