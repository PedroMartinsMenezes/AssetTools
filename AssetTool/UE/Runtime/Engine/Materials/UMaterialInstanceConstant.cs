namespace AssetTool
{
    [Location("void UMaterialInstance::Serialize(FArchive& Ar)")]
    [JsonAsset("MaterialInstanceConstant")]
    public class UMaterialInstanceConstant : UMaterialInstance
    {
        public const string TypeName = "MaterialInstanceConstant";
    }
}
