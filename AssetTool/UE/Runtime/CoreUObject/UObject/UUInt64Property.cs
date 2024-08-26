namespace AssetTool
{
    [Location("void UProperty::Serialize( FArchive& Ar )")]
    [JsonAsset("UInt64Property")]
    public class UUInt64Property : UNumericProperty
    {
        public const string TypeName = "UInt64Property";
    }
}
