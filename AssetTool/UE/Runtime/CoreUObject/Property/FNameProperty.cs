namespace AssetTool
{
    [Location("class COREUOBJECT_API FNameProperty : public FNameProperty_Super")]
    public class FNameProperty : FProperty
    {
        public const string TYPE_NAME = "NameProperty";
        public override string TypeName => TYPE_NAME;

        public FName Value;

        public override FField Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref Value);
            return this;
        }
    }
}
