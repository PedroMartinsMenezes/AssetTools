namespace AssetTool
{
    [JsonAsset("PrecomputedVisibilityOverrideVolume")]
    public class APrecomputedVisibilityOverrideVolume : AVolume
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}