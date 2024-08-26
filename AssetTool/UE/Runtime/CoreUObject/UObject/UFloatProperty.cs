namespace AssetTool
{
    [Location("void UProperty::Serialize( FArchive& Ar )")]
    [JsonAsset]
    public class UFloatProperty : UNumericProperty
    {
        public const string TypeName = "FloatProperty";
    }
}
