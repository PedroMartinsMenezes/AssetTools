namespace AssetTool
{
    [Location("void UPointLightComponent::Serialize(FArchive& Ar)")]
    public class USpotLightComponent : UPointLightComponent
    {
        public new const string TypeName = "SpotLightComponent";

        public new USpotLightComponent Move(Transfer transfer) => (USpotLightComponent)base.Move(transfer);
    }
}
