namespace AssetTool
{
    [Location("class COREUOBJECT_API FIntProperty : public TProperty_Numeric<int32>")]
    public class FIntProperty : FNumericProperty
    {
        public const string TYPE_NAME = "IntProperty";
        public override string TypeName => TYPE_NAME;

        public override FField Move(Transfer transfer)
        {
            base.Move(transfer);
            return this;
        }

        public int MoveValue(Transfer transfer, int value)
        {
            transfer.Move(ref value);
            return value;
        }
    }
}
