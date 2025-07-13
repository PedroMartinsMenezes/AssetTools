namespace AssetTool
{
    [JsonAsset("SmartObjectPersistentCollection")]
    public class ASmartObjectPersistentCollection : AActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}