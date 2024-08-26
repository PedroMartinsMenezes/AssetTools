namespace AssetTool
{
    [Location("void UProperty::Serialize( FArchive& Ar )")]
    [JsonAsset]
    public class UUInt16Property : UNumericProperty
    {
        public const string TypeName = "UInt16Property";
    }
}
