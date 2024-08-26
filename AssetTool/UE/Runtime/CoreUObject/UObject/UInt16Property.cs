namespace AssetTool
{
    [Location("void UProperty::Serialize( FArchive& Ar )")]
    [JsonAsset("Int16Property")]
    public class UInt16Property : UNumericProperty
    {
        public const string TypeName = "Int16Property";
    }
}
