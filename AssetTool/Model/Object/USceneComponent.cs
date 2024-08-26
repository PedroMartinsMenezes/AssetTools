namespace AssetTool
{
    [Location("void USceneComponent::Serialize(FArchive& Ar)")]
    [JsonAsset("SceneComponent")]
    public class USceneComponent : UActorComponent
    {
        public const string TypeName = "SceneComponent";
    }
}
