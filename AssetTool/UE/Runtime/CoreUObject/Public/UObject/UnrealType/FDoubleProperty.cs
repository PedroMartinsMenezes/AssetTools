namespace AssetTool
{
    public class FDoubleProperty : FNumericProperty
    {
        public new const string TYPE_NAME = "DoubleProperty";
        public override string TypeName => TYPE_NAME;

        public new FField Move(Transfer transfer)
        {
            base.Move(transfer);
            return this;
        }

        [Location("Slot << *TTypeFundamentals::GetPropertyValuePtr(Value);")]
        public static double MoveValue(Transfer transfer, double value)
        {
            transfer.Move(ref value);
            return value;
        }
    }
}
