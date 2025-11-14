namespace AssetTool
{
    [JsonAsset("PCGBoundsModifierSettings")]
    public class UPCGBoundsModifierSettings : UPCGSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}