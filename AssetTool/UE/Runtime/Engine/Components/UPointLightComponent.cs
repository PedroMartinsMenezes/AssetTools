namespace AssetTool
{
    [Location("void UPointLightComponent::Serialize(FArchive& Ar)")]
    [JsonAsset("PointLightComponent")]
    public class UPointLightComponent : ULocalLightComponent
    {
        public new const string TypeName = "PointLightComponent";
    }
}
