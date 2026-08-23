namespace AssetTool
{
    public class FInt64Property : FNumericProperty
    {
        public new const string TYPE_NAME = "Int64Property";
        public override string TypeName => TYPE_NAME;

        public override FField Move(Transfer transfer)
        {
            base.Move(transfer);
            return this;
        }

        [Location("Slot << *TTypeFundamentals::GetPropertyValuePtr(Value);")]
        public static Int64 MoveValue(Transfer transfer, Int64 value)
        {
            transfer.Move(ref value);
            return value;
        }
    }
}
