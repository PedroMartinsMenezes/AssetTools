namespace AssetTool
{
    [JsonAsset("LightComponent")]
    public class ULightComponent : ULightComponentBase
    {
        public FStaticShadowDepthMapData DepthMap = new();

        [Location("void ULightComponent::Serialize(FArchive& Ar)")]
        public override UObject Move(Transfer transfer)
        {
            base.Move(transfer);
            if (transfer.Supports.VER_UE4_STATIC_SHADOW_DEPTH_MAPS && !transfer.Supports.MapBuildDataSeparatePackage)
            {
                DepthMap.Move(transfer);
            }
            return this;
        }
    }
}