namespace AssetTool
{
    public class FDataflowConnection : ITransferible
    {
        public FGuid Guid;
        public FName Type;
        public FName Name;

        public virtual ITransferible Move2(Transfer transfer)
        {
            transfer.Move(ref Guid);
            transfer.Move(ref Type);
            transfer.Move(ref Name);
            return this;
        }
    }
}