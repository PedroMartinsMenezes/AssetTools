namespace AssetTool
{
    public class FSetProperty : FProperty
    {
        public new const string TYPE_NAME = "SetProperty";
        public override string TypeName => TYPE_NAME;

        public FName PropertyTypeName;
        public UInt32 A;
        public UInt32 B;

        public override FField Move(Transfer transfer)
        {
            transfer.Move(ref PropertyTypeName);
            transfer.Move(ref A); ///Fix this name
            transfer.Move(ref B); ///Fix this name

            return this;
        }
    }
}
