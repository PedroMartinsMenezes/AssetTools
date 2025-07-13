namespace AssetTool
{
    [JsonAsset("SharedMemoryMediaSource")]
    public class USharedMemoryMediaSource : UMediaSource
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}