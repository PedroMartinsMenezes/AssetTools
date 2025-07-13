namespace AssetTool
{
    [JsonAsset("SharedMemoryMediaOutput")]
    public class USharedMemoryMediaOutput : UMediaOutput
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}