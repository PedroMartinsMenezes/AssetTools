namespace AssetTool
{
    [Location("void UProperty::Serialize( FArchive& Ar )")]
    [JsonAsset]
    public class UInt16Property : UNumericProperty
    {
        public const string TypeName = "Int16Property";
    }
}
