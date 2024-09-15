namespace AssetTool
{
    [Location("void FInterfaceProperty::Serialize( FArchive& Ar )")]
    public class FInterfaceProperty : FProperty
    {
        public new const string TYPE_NAME = "InterfaceProperty";
        public override string TypeName => TYPE_NAME;

        public UInt32 Value;

        public override FField Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref Value);
            return this;
        }

        public FField MoveValue(Transfer transfer)
        {
            transfer.Move(ref Value);
            return this;
        }
    }
}
