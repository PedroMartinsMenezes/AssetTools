namespace AssetTool
{
    using InvocationListType = List<TScriptDelegate>;

    public class TScriptDelegate : ITransferible
    {
        public UInt32 Object;
        public FName FunctionName;

        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref Object);
            transfer.Move(ref FunctionName);
            return this;
        }
    }

    public class TMulticastScriptDelegate : ITransferible
    {
        public InvocationListType InvocationList;

        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref InvocationList);
            return this;
        }
    }
}
