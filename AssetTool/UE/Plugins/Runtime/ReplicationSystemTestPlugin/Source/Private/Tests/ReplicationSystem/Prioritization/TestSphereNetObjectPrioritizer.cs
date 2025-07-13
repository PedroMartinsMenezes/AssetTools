namespace AssetTool
{
    [JsonAsset("SphereNetObjectPrioritizerForTest")]
    public class USphereNetObjectPrioritizerForTest : USphereNetObjectPrioritizer
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}