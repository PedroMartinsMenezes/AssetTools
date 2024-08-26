namespace AssetTool
{
    [Location("void UBlueprint::Serialize(FArchive& Ar)")]
    [JsonAsset("Blueprint")]
    public class UBlueprint : UBlueprintCore
    {
        public const string TypeName = "Blueprint";
    }
}
