namespace AssetTool
{
    [Location("FNameProperty : public FNameProperty_Super")]
    public class FNameProperty : FProperty
    {
        public const string TYPE_NAME = "NameProperty";
        public override string TypeName => TYPE_NAME;
    }
}
