namespace AssetTool
{
    [TransferibleStruct("InstancedStruct")]
    public class FInstancedStruct : ITransferible
    {
        public ITransferible Move(Transfer transfer)
        {
            throw new NotImplementedException();
        }
    }
}