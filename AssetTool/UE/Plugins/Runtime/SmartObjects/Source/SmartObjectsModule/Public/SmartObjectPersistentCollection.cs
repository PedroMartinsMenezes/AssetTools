namespace AssetTool
{
    [JsonAsset("SmartObjectPersistentCollection")]
    public class ASmartObjectPersistentCollection : AActor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}