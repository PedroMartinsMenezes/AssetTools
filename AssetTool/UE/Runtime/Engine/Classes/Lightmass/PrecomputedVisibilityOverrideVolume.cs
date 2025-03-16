namespace AssetTool
{
    [JsonAsset("PrecomputedVisibilityOverrideVolume")]
    public class APrecomputedVisibilityOverrideVolume : AVolume
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}