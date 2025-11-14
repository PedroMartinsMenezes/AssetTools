namespace AssetTool
{
    public class FDataflowConnection : ITransferable
    {
        public FGuid Guid;
        public FName Type;
        public FName Name;

        public virtual ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref Guid);
            transfer.Move(ref Type);
            transfer.Move(ref Name);
            return this;
        }
    }
}