namespace AssetTool
{
    [Location("void UMaterialInstance::Serialize(FArchive& Ar)")]
    [JsonAsset]
    public class UMaterialInstanceConstant : UMaterialInstance
    {
        public const string TypeName = "MaterialInstanceConstant";
    }
}
