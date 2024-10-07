namespace AssetTool
{
    [JsonAsset("NetConnection")]
    public class UNetConnection : UPlayer
    {
        public UInt32 PackageMap;
        public List<TUInt32> Channels;

        [Location("void UNetConnection::Serialize( FArchive& Ar )")]
        public override UObject Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref PackageMap);
            transfer.Move(ref Channels);
            return this;
        }
    }
}
