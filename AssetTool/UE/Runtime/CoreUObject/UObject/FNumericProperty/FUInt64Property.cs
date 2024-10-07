namespace AssetTool
{
    public class FUInt64Property : FNumericProperty
    {
        public new const string TYPE_NAME = "UInt64Property";
        public override string TypeName => TYPE_NAME;

        public override FField Move(Transfer transfer)
        {
            base.Move(transfer);
            return this;
        }

        [Location("Slot << *TTypeFundamentals::GetPropertyValuePtr(Value);")]
        public static UInt64 MoveValue(Transfer transfer, UInt64 value)
        {
            transfer.Move(ref value);
            return value;
        }
    }
}
