namespace AssetTool
{
    [Location("void UCameraComponent::Serialize(FArchive& Ar)")]
    [JsonAsset]
    public class UCameraComponent : USceneComponent
    {
        public new const string TypeName = "CameraComponent";
    }
}
