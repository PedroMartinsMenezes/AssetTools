namespace AssetTool
{
    [Location("void FSoftClassProperty::Serialize( FArchive& Ar )")]
    public class FSoftClassProperty : FSoftObjectProperty
    {
        public new const string TYPE_NAME = "SoftClassProperty";
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
