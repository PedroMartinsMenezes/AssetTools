namespace AssetTool
{
    public class FNameProperty : FProperty
    {
        public new const string TYPE_NAME = "NameProperty";
        public override string TypeName => TYPE_NAME;

        [Location("Slot << *TTypeFundamentals::GetPropertyValuePtr(Value);")]
        public static FName MoveValue(Transfer transfer, FName value)
        {
            transfer.Move(ref value);
            return value;
        }
    }
}
