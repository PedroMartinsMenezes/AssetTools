namespace AssetTool
{
    [Location("class COREUOBJECT_API FStrProperty : public FStrProperty_Super")]
    public class FStrProperty : FProperty
    {
        public new const string TYPE_NAME = "StrProperty";
        public override string TypeName => TYPE_NAME;

        public static FString MoveValue(Transfer transfer, FString value)
        {
            transfer.Move(ref value);
            return value;
        }
    }
}
