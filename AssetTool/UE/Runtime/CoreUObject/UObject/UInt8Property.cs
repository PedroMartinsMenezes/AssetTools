namespace AssetTool
{
    [Location("void UProperty::Serialize( FArchive& Ar )")]
    [JsonAsset]
    public class UInt8Property : UNumericProperty
    {
        public const string TypeName = "Int8Property";
    }
}
