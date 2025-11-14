namespace AssetTool
{
    [JsonAsset("DirectionalLightComponent")]
    public class UDirectionalLightComponent : ULightComponent
    {
        [Location("void UDirectionalLightComponent::Serialize(FArchive& Ar)")]
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}