namespace AssetTool
{
    [Location("void UProperty::Serialize( FArchive& Ar )")]
    [JsonAsset("FloatProperty")]
    public class UFloatProperty : UNumericProperty
    {
        public const string TypeName = "FloatProperty";
    }
}
