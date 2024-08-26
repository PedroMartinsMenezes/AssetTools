namespace AssetTool
{
    [Location("void UProperty::Serialize( FArchive& Ar )")]
    [JsonAsset("Int8Property")]
    public class UInt8Property : UNumericProperty
    {
        public const string TypeName = "Int8Property";
    }
}
