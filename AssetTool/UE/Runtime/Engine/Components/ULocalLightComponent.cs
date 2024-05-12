namespace AssetTool
{
    [Location("void ULocalLightComponent::Serialize(FArchive& Ar)")]
    public class ULocalLightComponent : ULightComponent
    {
        public new ULocalLightComponent Move(Transfer transfer) => (ULocalLightComponent)base.Move(transfer);
    }
}
