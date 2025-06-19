namespace AssetTool
{
    [JsonAsset("PCGApplyScaleToBoundsSettings")]
    public class UPCGApplyScaleToBoundsSettings : UPCGSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}