namespace AssetTool
{
    [Location("void USceneComponent::Serialize(FArchive& Ar)")]
    [JsonAsset]
    public class USceneComponent : UActorComponent
    {
        public const string TypeName = "SceneComponent";
    }
}
