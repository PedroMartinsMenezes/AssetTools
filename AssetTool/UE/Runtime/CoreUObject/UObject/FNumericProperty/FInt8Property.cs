namespace AssetTool
{
    [Location("class COREUOBJECT_API FInt8Property : public TProperty_Numeric<int8>")]
    public class FInt8Property : FNumericProperty
    {
        public new const string TYPE_NAME = "Int8Property";
        public override string TypeName => TYPE_NAME;

        public override FField Move(Transfer transfer)
        {
            base.Move(transfer);
            return this;
        }

        public static sbyte MoveValue(Transfer transfer, sbyte value)
        {
            transfer.Move(ref value);
            return value;
        }
    }
}
