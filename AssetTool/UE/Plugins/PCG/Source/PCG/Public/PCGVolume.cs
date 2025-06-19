namespace AssetTool
{
    [JsonAsset("PCGVolume")]
    public class APCGVolume : AVolume
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}