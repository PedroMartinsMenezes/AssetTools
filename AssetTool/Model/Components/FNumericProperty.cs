namespace AssetTool
{
    public class FNumericProperty : FProperty
    {
        public new const string TYPE_NAME = "NumericProperty";

        [Location("void FNumericProperty::Serialize(FArchive& Ar)")]
        public override FField Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
