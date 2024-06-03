namespace AssetTool
{
    public class FSetProperty : FProperty
    {
        public const string TYPE_NAME = "SetProperty";
        public override string TypeName => TYPE_NAME;

        public override FField Move(Transfer transfer)
        {
            return this;
        }
    }
}
