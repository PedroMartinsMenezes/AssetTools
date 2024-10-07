namespace AssetTool
{
    public class FStrProperty : FProperty
    {
        public new const string TYPE_NAME = "StrProperty";
        public override string TypeName => TYPE_NAME;

        [Location("Slot << *TTypeFundamentals::GetPropertyValuePtr(Value);")]
        public static FString MoveValue(Transfer transfer, FString value)
        {
            transfer.Move(ref value);
            return value;
        }
    }
}
