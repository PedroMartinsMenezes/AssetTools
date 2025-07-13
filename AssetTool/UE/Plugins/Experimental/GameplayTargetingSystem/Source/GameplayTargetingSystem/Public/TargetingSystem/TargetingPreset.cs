namespace AssetTool
{
    [JsonAsset("TargetingPreset")]
    public class UTargetingPreset : UDataAsset
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}