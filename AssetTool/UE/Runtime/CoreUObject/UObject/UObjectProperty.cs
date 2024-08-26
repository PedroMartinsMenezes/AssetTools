namespace AssetTool
{
    [Location("void UObjectPropertyBase::Serialize(FArchive& Ar)")]
    [JsonAsset]
    public class UObjectProperty : UObjectPropertyBase
    {
        public const string TypeName = "ObjectProperty";
    }
}
