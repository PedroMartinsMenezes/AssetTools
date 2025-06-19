namespace AssetTool
{
    [JsonAsset("PrecomputedVisibilityVolume")]
    public class APrecomputedVisibilityVolume : AVolume
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}