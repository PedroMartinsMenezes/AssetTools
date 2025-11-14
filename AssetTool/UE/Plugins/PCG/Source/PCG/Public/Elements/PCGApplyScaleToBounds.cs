namespace AssetTool
{
    [JsonAsset("PCGApplyScaleToBoundsSettings")]
    public class UPCGApplyScaleToBoundsSettings : UPCGSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}