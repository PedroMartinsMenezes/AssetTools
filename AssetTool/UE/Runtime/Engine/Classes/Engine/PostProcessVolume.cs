namespace AssetTool
{
    [JsonAsset("PostProcessVolume")]
    public class APostProcessVolume : AVolume
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}