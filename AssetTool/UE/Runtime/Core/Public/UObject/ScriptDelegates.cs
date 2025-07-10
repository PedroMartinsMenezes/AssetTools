namespace AssetTool
{
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
}
