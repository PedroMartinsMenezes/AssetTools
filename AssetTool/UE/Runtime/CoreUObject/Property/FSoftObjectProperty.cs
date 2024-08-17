namespace AssetTool
{
    [Location("FSoftObjectProperty : public TFObjectPropertyBase<FSoftObjectPtr>")]
    public class FSoftObjectProperty : FProperty
    {
        public const string TYPE_NAME = "SoftObjectProperty";
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
