namespace AssetTool
{
    [JsonAsset("MassObserverProcessor")]
    public class UMassObserverProcessor : UMassProcessor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}