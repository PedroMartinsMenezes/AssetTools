namespace AssetTool
{
    [JsonAsset("SharedMemoryMediaOutputFactory")]
    public class USharedMemoryMediaOutputFactory : UFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}