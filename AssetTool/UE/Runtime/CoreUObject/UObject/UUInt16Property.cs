namespace AssetTool
{
    [Location("void UProperty::Serialize( FArchive& Ar )")]
    [JsonAsset("UInt16Property")]
    public class UUInt16Property : UNumericProperty
    {
        public const string TypeName = "UInt16Property";
    }
}
