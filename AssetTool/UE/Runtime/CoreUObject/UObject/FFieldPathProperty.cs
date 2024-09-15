namespace AssetTool
{
    public class FFieldPathProperty : FProperty
    {
        public new const string TYPE_NAME = "FieldPathProperty";
        public override string TypeName => TYPE_NAME;

        public UInt32 InOwner;
        public FName InName;
        public UInt32 InObjectFlags;

        public override FField Move(Transfer transfer)
        {
            transfer.Move(ref InOwner);
            transfer.Move(ref InName);
            transfer.Move(ref InObjectFlags);
            return this;
        }
    }
}
