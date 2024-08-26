namespace AssetTool
{
    [Location("void UProperty::Serialize( FArchive& Ar )")]
    [JsonAsset]
    public class UUInt32Property : UNumericProperty
    {
        public const string TypeName = "UInt32Property";
    }
}
