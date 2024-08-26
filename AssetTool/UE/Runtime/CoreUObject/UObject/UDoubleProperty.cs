namespace AssetTool
{
    [Location("void UProperty::Serialize( FArchive& Ar )")]
    [JsonAsset("DoubleProperty")]
    public class UDoubleProperty : UNumericProperty
    {
        public const string TypeName = "DoubleProperty";
    }
}
