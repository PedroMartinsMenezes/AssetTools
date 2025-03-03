namespace AssetTool
{
    [JsonAsset("PCGBoundsModifierSettings")]
    public class UPCGBoundsModifierSettings : UPCGSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}