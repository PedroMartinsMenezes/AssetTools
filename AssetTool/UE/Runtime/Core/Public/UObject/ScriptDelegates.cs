namespace AssetTool
{
    using InvocationListType = List<TScriptDelegate>;

    public class TScriptDelegate : ITransferable
    {
        public UInt32 Object;
        public FName FunctionName;

        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref Object);
            transfer.Move(ref FunctionName);
            return this;
        }
    }

    public class TMulticastScriptDelegate : ITransferable
    {
        public InvocationListType InvocationList;

        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref InvocationList);
            return this;
        }
    }
}
