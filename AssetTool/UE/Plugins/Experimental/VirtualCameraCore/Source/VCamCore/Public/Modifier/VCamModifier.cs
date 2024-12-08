namespace AssetTool
{
    [JsonAsset("VCamModifier")]
    public class UVCamModifier : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("VCamBlueprintModifier")]
    public class UVCamBlueprintModifier : UVCamModifier
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}