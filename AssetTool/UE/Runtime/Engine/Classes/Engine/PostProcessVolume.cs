namespace AssetTool
{
    [JsonAsset("PostProcessVolume")]
    public class APostProcessVolume : AVolume
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}