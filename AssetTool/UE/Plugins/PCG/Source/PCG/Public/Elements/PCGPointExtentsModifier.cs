namespace AssetTool
{
    [JsonAsset("PCGPointExtentsModifierSettings")]
    public class UPCGPointExtentsModifierSettings : UPCGSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}