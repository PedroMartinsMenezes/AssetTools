namespace AssetTool
{
    [JsonAsset("PointLightComponent")]
    public class UPointLightComponent : UObject
    {
        [Location("void UPointLightComponent::Serialize(FArchive& Ar)")]
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}