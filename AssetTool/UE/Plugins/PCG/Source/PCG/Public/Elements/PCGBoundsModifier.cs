namespace AssetTool
{
    [JsonAsset("PCGBoundsModifierSettings")]
    public class UPCGBoundsModifierSettings : UPCGSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}