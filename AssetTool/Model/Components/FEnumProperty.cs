namespace AssetTool
{
    [Location("void FEnumProperty::Serialize( FArchive& Ar )")]
    public class FEnumProperty : FProperty
    {
        public const string TYPE_NAME = "EnumProperty";
        public override string TypeName => TYPE_NAME;
    }
}
