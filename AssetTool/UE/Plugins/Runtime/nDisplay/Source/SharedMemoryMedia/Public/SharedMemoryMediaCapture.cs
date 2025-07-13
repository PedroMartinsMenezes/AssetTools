namespace AssetTool
{
    [JsonAsset("SharedMemoryMediaCapture")]
    public class USharedMemoryMediaCapture : UMediaCapture
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}