namespace AssetTool
{
    [JsonAsset("MassNetworkIDFragmentInitializer")]
    public class UMassNetworkIDFragmentInitializer : UMassObserverProcessor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}