namespace AssetTool
{
    [Location("void UProperty::Serialize( FArchive& Ar )")]
    [JsonAsset]
    public class UIntProperty : UNumericProperty
    {
        public const string TypeName = "IntProperty";
    }
}
