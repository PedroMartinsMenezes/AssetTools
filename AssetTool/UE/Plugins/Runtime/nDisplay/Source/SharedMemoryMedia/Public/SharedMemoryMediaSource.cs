namespace AssetTool
{
    [JsonAsset("SharedMemoryMediaSource")]
    public class USharedMemoryMediaSource : UMediaSource
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}