namespace AssetTool
{
    [Location("void FStructProperty::Serialize( FArchive& Ar )")]
    public class FStructProperty : FProperty
    {
        public const string TYPE_NAME = "StructProperty";
        public override string TypeName => TYPE_NAME;

        public UInt32 Value;

        public new FStructProperty Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref Value);
            return this;
        }
    }
}
