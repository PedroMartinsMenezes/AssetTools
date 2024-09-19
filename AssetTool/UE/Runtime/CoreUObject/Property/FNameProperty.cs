namespace AssetTool
{
    [Location("FNameProperty : public FNameProperty_Super")]
    public class FNameProperty : FProperty
    {
        public new const string TYPE_NAME = "NameProperty";
        public override string TypeName => TYPE_NAME;

        public FName MoveValue(Transfer transfer, FName value)
        {
            transfer.Move(ref value);
            return value;
        }
    }
}
