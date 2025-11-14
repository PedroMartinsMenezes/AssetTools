namespace AssetTool
{
    [JsonAsset("PrecomputedVisibilityVolume")]
    public class APrecomputedVisibilityVolume : AVolume
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}