namespace AssetTool
{
    [Location("void UProperty::Serialize( FArchive& Ar )")]
    [JsonAsset("IntProperty")]
    public class UIntProperty : UNumericProperty
    {
        public const string TypeName = "IntProperty";
    }
}
