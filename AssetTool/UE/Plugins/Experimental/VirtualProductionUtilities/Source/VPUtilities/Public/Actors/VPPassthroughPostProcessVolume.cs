namespace AssetTool
{
    [JsonAsset("VPPassthroughPostProcessVolume")]
    public class AVPPassthroughPostProcessVolume : APostProcessVolume
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}