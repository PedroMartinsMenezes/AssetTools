namespace AssetTool
{
    public class FInt16Property : FNumericProperty
    {
        public new const string TYPE_NAME = "Int16Property";
        public override string TypeName => TYPE_NAME;

        public override FField Move(Transfer transfer)
        {
            base.Move(transfer);
            return this;
        }

        [Location("Slot << *TTypeFundamentals::GetPropertyValuePtr(Value);")]
        public static Int16 MoveValue(Transfer transfer, Int16 value)
        {
            transfer.Move(ref value);
            return value;
        }
    }
}
