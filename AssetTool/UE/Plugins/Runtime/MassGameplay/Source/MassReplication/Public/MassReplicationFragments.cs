namespace AssetTool
{
    [JsonAsset("MassNetworkIDFragmentInitializer")]
    public class UMassNetworkIDFragmentInitializer : UMassObserverProcessor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}