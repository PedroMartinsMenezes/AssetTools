namespace AssetTool
{
    public class FISMClientHandle : ITransferible
    {
        public Int32 Index;
        public FGuid Guid;

        [Location("void Serialize(FArchive& Ar)")]
        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref Index);
            transfer.Move(ref Guid);
            return this;
        }
    }
}
