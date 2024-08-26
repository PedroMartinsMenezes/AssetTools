namespace AssetTool
{
    [Location("void UProperty::Serialize( FArchive& Ar )")]
    [JsonAsset("UInt32Property")]
    public class UUInt32Property : UNumericProperty
    {
        public const string TypeName = "UInt32Property";
    }
}
