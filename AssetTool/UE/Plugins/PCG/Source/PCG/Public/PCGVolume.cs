namespace AssetTool
{
    [JsonAsset("PCGVolume")]
    public class APCGVolume : AVolume
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}