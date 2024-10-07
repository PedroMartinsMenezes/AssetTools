namespace AssetTool
{
    public class FStructProperty : FProperty
    {
        public new const string TYPE_NAME = "StructProperty";
        public override string TypeName => TYPE_NAME;

        public Int32 Value;

        [Location("void FStructProperty::Serialize( FArchive& Ar )")]
        public override FField Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref Value);
            return this;
        }
    }
}
