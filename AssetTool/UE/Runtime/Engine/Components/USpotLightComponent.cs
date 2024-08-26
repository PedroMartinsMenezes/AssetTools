namespace AssetTool
{
    [Location("void UPointLightComponent::Serialize(FArchive& Ar)")]
    [JsonAsset("SpotLightComponent")]
    public class USpotLightComponent : UPointLightComponent
    {
        public new const string TypeName = "SpotLightComponent";
    }
}
