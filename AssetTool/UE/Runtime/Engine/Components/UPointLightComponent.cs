namespace AssetTool
{
    [Location("void UPointLightComponent::Serialize(FArchive& Ar)")]
    [JsonAsset]
    public class UPointLightComponent : ULocalLightComponent
    {
        public new const string TypeName = "PointLightComponent";
    }
}
