namespace AssetTool
{
    [JsonAsset("PointLightComponent")]
    public class UPointLightComponent : ULocalLightComponent
    {
        [Location("void UPointLightComponent::Serialize(FArchive& Ar)")]
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}