namespace AssetTool
{
    [JsonAsset("PrecomputedVisibilityVolume")]
    public class APrecomputedVisibilityVolume : AVolume
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}