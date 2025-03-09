namespace AssetTool
{
    public class FObjectPtrProperty : FProperty
    {
        public new const string TYPE_NAME = "ObjectPtrProperty";
        public override string TypeName => TYPE_NAME;

        public UInt32 Value;

        public override FField Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref Value);
            return this;
        }
    }
}
