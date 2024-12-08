namespace AssetTool
{
    [JsonAsset("StreamingSettings")]
    public class UStreamingSettings : UDeveloperSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("GarbageCollectionSettings")]
    public class UGarbageCollectionSettings : UDeveloperSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}