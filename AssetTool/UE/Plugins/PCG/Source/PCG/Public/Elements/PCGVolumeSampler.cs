namespace AssetTool
{
    [JsonAsset("PCGVolumeSamplerSettings")]
    public class UPCGVolumeSamplerSettings : UPCGSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}