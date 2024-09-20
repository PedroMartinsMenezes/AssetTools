namespace AssetTool
{
    [JsonAsset("NetConnection")]
    [Location("void UNetConnection::Serialize( FArchive& Ar )")]
    public class UNetConnection : UPlayer
    {
        public UInt32 PackageMap;
        public List<TUInt32> Channels = [];

        public override UObject Move(Transfer transfer)
        {
            base.Move(transfer);

            transfer.Move(ref PackageMap);

            Channels.Resize(transfer);
            Channels.ForEach(x => x.Move(transfer));

            return this;
        }
    }
}
