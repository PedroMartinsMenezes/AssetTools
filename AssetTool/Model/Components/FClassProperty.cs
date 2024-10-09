namespace AssetTool
{
    public class FClassProperty : FObjectProperty
    {
        public new const string TYPE_NAME = "ClassProperty";
        public override string TypeName => TYPE_NAME;

        public UInt32 MetaClass;

        public override FField Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref MetaClass);
            return this;
        }
    }
}
