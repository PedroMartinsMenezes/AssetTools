namespace AssetTool
{
    [JsonAsset("SharedMemoryMediaSourceFactory")]
    public class USharedMemoryMediaSourceFactory : UFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}