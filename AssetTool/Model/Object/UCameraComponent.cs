namespace AssetTool
{
    [Location("void UCameraComponent::Serialize(FArchive& Ar)")]
    [JsonAsset("CameraComponent")]
    public class UCameraComponent : USceneComponent
    {
        public new const string TypeName = "CameraComponent";
    }
}
