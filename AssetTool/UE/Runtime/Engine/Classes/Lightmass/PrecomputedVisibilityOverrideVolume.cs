namespace AssetTool
{
    [JsonAsset("PrecomputedVisibilityOverrideVolume")]
    public class APrecomputedVisibilityOverrideVolume : AVolume
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}