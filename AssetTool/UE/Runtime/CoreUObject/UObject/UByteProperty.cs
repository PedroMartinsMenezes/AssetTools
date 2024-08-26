namespace AssetTool
{
    [Location("void UProperty::Serialize( FArchive& Ar )")]
    [JsonAsset]
    public class UByteProperty : UNumericProperty
    {
        public const string TypeName = "ByteProperty";
    }
}
