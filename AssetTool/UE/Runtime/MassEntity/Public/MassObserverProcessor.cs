namespace AssetTool
{
    [JsonAsset("MassObserverProcessor")]
    public class UMassObserverProcessor : UMassProcessor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}