namespace AssetTool
{
    [JsonAsset("PCGVolumeSamplerSettings")]
    public class UPCGVolumeSamplerSettings : UPCGSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}