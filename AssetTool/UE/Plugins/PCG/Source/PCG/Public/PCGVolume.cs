namespace AssetTool
{
    [JsonAsset("PCGVolume")]
    public class APCGVolume : AVolume
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}