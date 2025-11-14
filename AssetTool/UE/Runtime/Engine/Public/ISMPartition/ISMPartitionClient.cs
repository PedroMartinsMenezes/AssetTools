namespace AssetTool
{
    public class FISMClientHandle : ITransferable
    {
        public Int32 Index;
        public FGuid Guid;

        [Location("void Serialize(FArchive& Ar)")]
        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref Index);
            transfer.Move(ref Guid);
            return this;
        }
    }
}
