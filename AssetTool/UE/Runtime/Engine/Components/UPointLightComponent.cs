namespace AssetTool
{
    [JsonAsset("PointLightComponent")]
    public class UPointLightComponent : ULocalLightComponent
    {
        [Location("void UPointLightComponent::Serialize(FArchive& Ar)")]
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
