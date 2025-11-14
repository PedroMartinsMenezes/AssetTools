namespace AssetTool
{
    [JsonAsset("SphereNetObjectPrioritizerForTest")]
    public class USphereNetObjectPrioritizerForTest : USphereNetObjectPrioritizer
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}