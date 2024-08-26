namespace AssetTool
{
    [Location("void UProperty::Serialize( FArchive& Ar )")]
    [JsonAsset("ByteProperty")]
    public class UByteProperty : UNumericProperty
    {
        public const string TypeName = "ByteProperty";
    }
}
