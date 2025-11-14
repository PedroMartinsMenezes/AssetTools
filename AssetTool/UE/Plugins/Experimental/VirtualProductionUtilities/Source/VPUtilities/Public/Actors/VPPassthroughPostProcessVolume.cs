namespace AssetTool
{
    [JsonAsset("VPPassthroughPostProcessVolume")]
    public class AVPPassthroughPostProcessVolume : APostProcessVolume
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}