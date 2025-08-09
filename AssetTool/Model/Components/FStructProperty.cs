namespace AssetTool
{
    public class FStructProperty : FProperty
    {
        public new const string TYPE_NAME = "StructProperty";
        public override string TypeName => TYPE_NAME;

        public Int32 Value;

        [Location("void FStructProperty::Serialize( FArchive& Ar )")]
        public override FField Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref Value);
            return this;
        }
    }

    public class FStructPropertyItem : ITransferible
    {
        public Dictionary<string, object> Value;

        public ITransferible Move(Transfer transfer)
        {
            Value = transfer.MoveTags(Value.ToObject<Dictionary<string, object>>(transfer), 0);
            return this;
        }
    }
}
