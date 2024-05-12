namespace AssetTool
{
    [Location("void UPointLightComponent::Serialize(FArchive& Ar)")]
    public class UPointLightComponent : ULocalLightComponent
    {
        public new const string TypeName = "PointLightComponent";

        public new UPointLightComponent Move(Transfer transfer) => (UPointLightComponent)base.Move(transfer);
    }
}
