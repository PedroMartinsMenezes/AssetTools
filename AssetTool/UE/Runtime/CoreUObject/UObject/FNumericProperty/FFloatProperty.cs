namespace AssetTool
{
    public class FFloatProperty : FNumericProperty
    {
        public new const string TYPE_NAME = "FloatProperty";
        public override string TypeName => TYPE_NAME;

        public override FField Move(Transfer transfer)
        {
            base.Move(transfer);
            return this;
        }

        [Location("Slot << *TTypeFundamentals::GetPropertyValuePtr(Value);")]
        public static float MoveValue(Transfer transfer, float value)
        {
            transfer.Move(ref value);
            return value;
        }
    }
}
