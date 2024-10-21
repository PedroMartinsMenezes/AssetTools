namespace AssetTool
{
    [JsonAsset("DirectionalLightComponent")]
    public class UDirectionalLightComponent : ULightComponent
    {
        [Location("void UDirectionalLightComponent::Serialize(FArchive& Ar)")]
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
