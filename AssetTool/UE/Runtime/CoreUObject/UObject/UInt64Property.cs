namespace AssetTool
{
    [Location("void UProperty::Serialize( FArchive& Ar )")]
    [JsonAsset]
    public class UInt64Property : UNumericProperty
    {
        public const string TypeName = "Int64Property";
    }
}
