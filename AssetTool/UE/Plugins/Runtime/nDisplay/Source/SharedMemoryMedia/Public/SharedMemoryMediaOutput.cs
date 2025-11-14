namespace AssetTool
{
    [JsonAsset("SharedMemoryMediaOutput")]
    public class USharedMemoryMediaOutput : UMediaOutput
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}