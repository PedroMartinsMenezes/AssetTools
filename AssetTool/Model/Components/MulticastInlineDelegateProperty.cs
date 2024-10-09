namespace AssetTool
{
    public class FMulticastInlineDelegateProperty : FProperty
    {
        public new const string TYPE_NAME = "MulticastInlineDelegateProperty";
        public override string TypeName => TYPE_NAME;

        public UInt32 PropertyValuePtr;

        public override FField Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref PropertyValuePtr);
            return this;
        }
    }
}
