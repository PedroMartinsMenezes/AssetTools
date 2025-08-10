namespace AssetTool
{
    [JsonAsset("MetaHumanPerformanceViewportSettings")]
    public class UMetaHumanPerformanceViewportSettings : UMetaHumanViewportSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}