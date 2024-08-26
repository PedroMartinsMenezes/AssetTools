namespace AssetTool
{
    [Location("void UProperty::Serialize( FArchive& Ar )")]
    [JsonAsset("Int64Property")]
    public class UInt64Property : UNumericProperty
    {
        public const string TypeName = "Int64Property";
    }
}
